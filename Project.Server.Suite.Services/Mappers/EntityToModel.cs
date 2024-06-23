using Project.Server.Suite.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Services.Mappers
{
    public static class EntityToModel
    {
        public static Trigger CreateTriggerFromEntity(Data.Entities.Trigger entity)
        {
            return new Trigger()
            {
                TriggerId = entity.TriggerId,
                TriggerMode = entity.TriggerMode,
                RevisionMode = entity.RevisionMode,
                ScheduleMode = entity.ScheduleMode,
                TimeSchedule = entity.TimeSchedule,
                WeekDay = entity.WeekDay
            };
        }

        public static ProjectServer CreateProjectServerFromEntity(Data.Entities.ProjectServer entity)
        {
            return new ProjectServer()
            {
                ProjectServerId = entity.ProjectServerId,
                ServerUrl = entity.ServerUrl,
                ServerName = entity.ServerName,
                HostName = entity.HostName,
                PortNumber = entity.PortNumber,
                Status = entity.Status,
                Description = entity.Description,
                DoRevisionCheck = entity.DoRevisionCheck,
            };
        }

        //public static T CreateStudentFromEntity<T>(Student entity) where T : IStudent
        //{
        //    var student = Activator.CreateInstance<T>();

        //    student.Id = entity.Id;
        //    student.Name = entity.Name;
        //    student.Surname = entity.Surname;
        //    student.DateOfBirth = DateTime.ParseExact(entity.DateOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        //    student.Sex = (Sex)entity.Sex;
        //    student.Address = CreateAddressFromEntity(entity.Address);
        //    return student;
        //}

        //public static Address? CreateAddressFromEntity(Data.Entities.Address entity)
        //{
        //    return new Address()
        //    {
        //        Id = entity.Id,
        //        AddressLine1 = entity?.AddressLine1 ?? string.Empty,
        //        AddressLine2 = entity?.AddressLine2 ?? string.Empty,
        //        AddressLine3 = entity?.AddressLine3 ?? string.Empty,
        //        County = entity?.County ?? string.Empty,
        //        Town = entity?.Town ?? string.Empty,
        //        PostCode = entity?.PostCode ?? string.Empty
        //    };
        //}
        //public static IEnumerable<Course>? CreateCoursesFromEntities(IEnumerable<Data.Entities.Course> courses)
        //{
        //    return courses.Select(CreateCourseFromEntity);
        //}

        //public static Course UpdateCourseFromEntity(Data.Entities.Course courseEntity, Course courseModel)
        //{
        //    return new Course()
        //    {
        //        Id = courseEntity.Id,
        //        Name = courseModel.Name,
        //        Description = courseModel.Description,
        //        StartDate = courseModel.StartDate
        //    };
        //}

        //public static Data.Entities.Course UpdateCourseFromModel(Data.Entities.Course courseEntity, Course courseModel)
        //{
        //    return new Data.Entities.Course()
        //    {
        //        Id = courseEntity.Id,
        //        Name = courseModel.Name,
        //        Description = courseModel.Description,
        //        StartDate = courseModel.StartDate.ToShortDateString()
        //    };
        //}

        //public static Data.Entities.Course CreateCourseFromModel(Course courseModel)
        //{
        //    return new Data.Entities.Course()
        //    {
        //        Id = courseModel.Id,
        //        Name = courseModel.Name,
        //        Description = courseModel.Description,
        //        StartDate = courseModel.StartDate.ToShortDateString()
        //    };
        //}
    }
}