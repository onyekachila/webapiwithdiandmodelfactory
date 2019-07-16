﻿using Learning.Data;
using Learning.Data.Entities;
using Learning.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Learning.Web.Controllers
{
    
    public class CoursesController : BaseApiController
    {
        public CoursesController(ILearningRepository repo)
               : base(repo)
        {

        }

        [HttpGet]
        [Route("api/courses", Name = "courses")]
        public IEnumerable<CourseModel> Get()
        {
            IQueryable<Course> query;

            query = TheRepository.GetAllCourses();

            var results = query
            .ToList()
            .Select(s => TheModelFactory.Create(s));

            return results;
        }

        //public List<Course> Get()
        //{
        //    ILearningRepository repository = new LearningRepository(new LearningContext());

        //    return repository.GetAllCourses().ToList();
        //}

        [HttpGet]
        [Route("api/courses/{id}")]
        public HttpResponseMessage GetCourse(int id)
        {
            try
            {
                var course = TheRepository.GetCourse(id);
                if (course != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, TheModelFactory.Create(course));
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        //public Course GetCourse(int id)
        //{
        //    ILearningRepository repository = new LearningRepository(new LearningContext());

        //    return repository.GetCourse(id);
        //}
    }
}
