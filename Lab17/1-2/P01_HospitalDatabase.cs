using P01_HospitalDatabase.Data;

using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Models;
using System;
using System.Linq;
using System.Text;
using System.Globalization;

namespace P01_HospitalDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now.ToString("dd-MM-yyyy");
            var time = DateTime.Now.ToString("HH:mm:ss");
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                using (var context = new HospitalContext())
                {
                    bool exit = false;
                    bool login = false;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine($"{data}             HealthHub               {time}");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Добрий день! Для початку введіть пошту та пароль!");
                    Console.Write("Пошта: "); string email = Console.ReadLine();
                    Console.Write("Пароль: "); string password = Console.ReadLine();

                    var doctor = context.Doctors.FirstOrDefault(d => d.Email == email && d.Password == password);

                    if (doctor != null)
                    {
                        Console.WriteLine($"Ласкаво просимо, {doctor.Name}! Ви увійшли в систему.");


                        while (!exit)
                        {
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine($"{data}             HealthHub               {time}");
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("1. Додати пацієнта");
                            Console.WriteLine("2. Переглянути пацієнтів");
                            Console.WriteLine("3. Додати медикамент");
                            Console.WriteLine("4. Призначити медикамент пацієнту");
                            Console.WriteLine("5. Призначити візит");
                            Console.WriteLine("0. Вихід");
                            Console.WriteLine("-------------------------------------------------------");
                            Console.Write("Оберіть дію: ");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    AddPatient(context);
                                    break;
                                case "2":
                                    ViewPatients(context);
                                    break;
                                case "3":
                                    AddMedicament(context);
                                    break;
                                case "4":
                                    AssignMedicament(context);
                                    break;
                                case "5":
                                    AddVisitation(context);
                                    break;
                                case "0":
                                    exit = true;
                                    break;
                                default:
                                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                                    break;
                            }

                            Console.WriteLine("Натисніть будь-яку клавішу для продовження...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неправильний логін та пароль або такого доктора не існує!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ex.InnerException?.Message);
                Console.ResetColor();
            }
        }

        
        static void AddPatient(HospitalContext context)
        {
            Console.Write("Введіть ім'я пацієнта: ");
            var firstName = Console.ReadLine();
            Console.Write("Введіть прізвище пацієнта: ");
            var lastName = Console.ReadLine();
            Console.Write("Введіть адресу пацієнта: ");
            var address = Console.ReadLine();
            Console.Write("Введіть електронну пошту пацієнта: ");
            var email = Console.ReadLine();
            Console.Write("Чи має пацієнт страховку? (true/false): ");
            var hasInsurance = bool.Parse(Console.ReadLine());

            var patient = new Patient
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Email = email,
                HasInsurance = hasInsurance
            };

            context.Patients.Add(patient);
            context.SaveChanges();

            Console.WriteLine("Пацієнта успішно додано.");
        }

        private static void ViewPatients(HospitalContext context)
        {
            var patients = context.Patients.ToList();
            Console.WriteLine("Список пацієнтів:");

            foreach (var patient in patients)
            {
                Console.WriteLine($"ID: {patient.PatientId}, Ім'я: {patient.FirstName}, Прізвище: {patient.LastName}, Електронна пошта: {patient.Email}");
            }
        }

        private static void AddMedicament(HospitalContext context)
        {
            Console.Write("Введіть назву медикаменту: ");
            string name = Console.ReadLine();

            var medicament = new Medicament
            {
                Name = name
            };

            context.Medicaments.Add(medicament);
            context.SaveChanges();

            Console.WriteLine("Медикамент успішно додано.");
        }

        private static void AssignMedicament(HospitalContext context)
        {
            Console.Write("Введіть ID пацієнта: ");
            int patientId = int.Parse(Console.ReadLine());
            Console.Write("Введіть ID медикаменту: ");
            int medicamentId = int.Parse(Console.ReadLine());

            var patient = context.Patients.FirstOrDefault(p => p.PatientId == patientId);
            var medicament = context.Medicaments.FirstOrDefault(m => m.MedicamentId == medicamentId);

            if (patient != null && medicament != null)
            {
                var patientMedicament = new PatientMedicament
                {
                    PatientId = patientId,
                    MedicamentId = medicamentId
                };

                context.PatientMedicaments.Add(patientMedicament);
                context.SaveChanges();

                Console.WriteLine("Медикамент успішно призначено пацієнту.");
            }
            else
            {
                Console.WriteLine("Пацієнта або медикаменту з таким ID не знайдено.");
            }
        }

        private static void AddVisitation(HospitalContext context)
        {
            Console.Write("Введіть дату (формат: dd-MM-yyyy): ");
            string datetime = Console.ReadLine();
            string format = "dd-MM-yyyy";
            Console.Write("Введіть коментарі: ");
            string comments = Console.ReadLine();
            Console.Write("Введіть ID пацієнта: ");
            int patientId = int.Parse(Console.ReadLine());
            Console.Write("Введіть ID лікаря: ");
            int doctorId = int.Parse(Console.ReadLine());

            if (DateTime.TryParseExact(datetime, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
            {
                var patient = context.Patients.Find(patientId);
                var doctor = context.Doctors.Find(doctorId);

                if (patient == null)
                {
                    Console.WriteLine("Пацієнта з таким ID не знайдено.");
                    return;
                }
                if (doctor == null)
                {
                    Console.WriteLine("Лікаря з таким ID не знайдено.");
                    return;
                }

                var visitation = new Visitation
                {
                    Date = dateTime,
                    Comments = comments,
                    Patient = patient,
                    Doctor = doctor
                };


                context.Visitations.Add(visitation);
                context.SaveChanges();

                Console.WriteLine("Відвідування успішно додано!");
            }
            else
            {
                Console.WriteLine("Невірний формат дати та часу. Будь ласка, спробуйте ще раз.");
            }

        }
    }
}
