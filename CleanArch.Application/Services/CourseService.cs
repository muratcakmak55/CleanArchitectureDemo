﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _mediatorHandler;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler mediatorHandler)
        {
            _courseRepository = courseRepository;
            _mediatorHandler = mediatorHandler;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var command = new CreateCourseCommand(
                courseViewModel.Name, 
                courseViewModel.Description, 
                courseViewModel.ImageUrl);

            _mediatorHandler.SendCommand(command);
        }

        public CourseViewModel GetCourses()
        {

            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
