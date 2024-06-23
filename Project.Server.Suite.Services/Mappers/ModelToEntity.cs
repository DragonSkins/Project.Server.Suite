using Project.Server.Suite.Base;

namespace Project.Server.Suite.Services.Mappers
{
    internal static class ModelToEntity
    {
        public static Data.Entities.Trigger CreateEntityFromTrigger(Trigger trigger)
        {
            if (trigger == null)
                throw new ArgumentNullException(nameof(trigger));

            return new Data.Entities.Trigger()
            {
                TriggerId = trigger.TriggerId,
                TriggerMode = trigger.TriggerMode,
                RevisionMode = trigger.RevisionMode,
                ScheduleMode = trigger.ScheduleMode,
                TimeSchedule = trigger.TimeSchedule,
                WeekDay = trigger.WeekDay
            };
        }

        public static Data.Entities.Trigger UpdateEntityFromTrigger(Data.Entities.Trigger triggerEntity, Trigger triggerModel)
        {
            if (triggerEntity == null)
                throw new ArgumentNullException(nameof(triggerEntity));

            if (triggerModel == null)
                throw new ArgumentNullException(nameof(triggerModel));

            triggerEntity.TriggerMode = triggerModel.TriggerMode;
            triggerEntity.RevisionMode = triggerModel.RevisionMode;
            triggerEntity.ScheduleMode = triggerModel.ScheduleMode;
            triggerEntity.TimeSchedule = triggerModel.TimeSchedule;
            triggerEntity.WeekDay = triggerModel.WeekDay;
            return triggerEntity;
        }

        public static Data.Entities.ProjectServer CreateEntityFromProjectServer(ProjectServer projectServer)
        {
            if(projectServer == null)
                throw new ArgumentNullException(nameof(projectServer));

            return new Data.Entities.ProjectServer()
            {
                ProjectServerId = projectServer.ProjectServerId,
                ServerUrl = projectServer.ServerUrl,
                ServerName = projectServer.ServerName,
                HostName = projectServer.HostName,
                PortNumber = projectServer.PortNumber,
                Status = projectServer.Status,
                Description = projectServer.Description,
                DoRevisionCheck = projectServer.DoRevisionCheck
            };
        }

        public static Data.Entities.ProjectServer UpdateEntityFromProjectServer(Data.Entities.ProjectServer projectServerEntity, ProjectServer projectServer)
        {
            if(projectServerEntity == null)
                throw new ArgumentNullException(nameof(projectServerEntity));

            if(projectServer == null)
                throw new ArgumentNullException(nameof(projectServer));

            projectServerEntity.ServerUrl = projectServer.ServerUrl;
            projectServerEntity.ServerName = projectServer.ServerName;
            projectServerEntity.HostName = projectServer.HostName;
            projectServerEntity.PortNumber = projectServer.PortNumber;
            projectServerEntity.Status = projectServer.Status;
            projectServerEntity.Description = projectServer.Description;
            projectServerEntity.DoRevisionCheck = projectServer.DoRevisionCheck;

            return projectServerEntity;
        }
    }
}
