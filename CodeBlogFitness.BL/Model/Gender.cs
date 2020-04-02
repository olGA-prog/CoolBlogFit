using System;

namespace CodeBlogFitness.BL.Model
{
   public  class Gender
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }


        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name">Имя пола.</param>
        public Gender (string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым", nameof(name));
            }
            Name = name;

        }

        public override string ToString()
        {
            return Name;
        }


    }
}
