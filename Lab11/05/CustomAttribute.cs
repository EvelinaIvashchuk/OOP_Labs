using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CustomAttribute : Attribute
    {
        private string author;
        private int revision;
        private string description;
        private List<string> reviewers;

        public CustomAttribute(string author, int revision, string description, params string[] inputReviewers)
        {
            this.author = author;
            this.revision = revision;
            this.description = description;
            reviewers = new List<string>();

            foreach (string inputReviewer in inputReviewers)
            {
                reviewers.Add(inputReviewer);
            }
        }

        public string Print(string element)
        {
            switch (element)
            {
                case "Author":
                    return $"Author: {author}";

                case "Revision":
                    return $"Revision: {revision}";

                case "Description":
                    return $"Class description: {description}";

                case "Reviewers":
                    return $"Reviewers: {string.Join(", ", reviewers)}";
            }

            return string.Empty;
        }
    }
}
