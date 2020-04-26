using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Commands
{
    public class CreateCourseCommand:CourseCommand
    {
        public CreateCourseCommand(string name,string desription,string imageUrl)
        {
            Name = name;
            Description = desription;
            ImageUrl = imageUrl;
        }
    }
}
