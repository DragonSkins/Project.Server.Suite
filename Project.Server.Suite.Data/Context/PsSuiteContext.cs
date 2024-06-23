using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Project.Server.Suite.Data.Entities;

namespace Project.Server.Suite.Data.Context;

public partial class PsSuiteContext : DbContext
{
    public PsSuiteContext()
    {
    }

    public PsSuiteContext(DbContextOptions<PsSuiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActionParameter> ActionParameters { get; set; }

    public virtual DbSet<ActionParameterType> ActionParameterTypes { get; set; }

    public virtual DbSet<ActionScript> ActionScripts { get; set; }

    public virtual DbSet<MailNotification> MailNotifications { get; set; }

    public virtual DbSet<ProjectGroup> ProjectGroups { get; set; }

    public virtual DbSet<ProjectServer> ProjectServers { get; set; }

    public virtual DbSet<PssTask> PssTasks { get; set; }

    public virtual DbSet<PssWorkerLable> PssWorkerLables { get; set; }

    public virtual DbSet<Revision> Revisions { get; set; }

    public virtual DbSet<ServiceNotification> ServiceNotifications { get; set; }

    public virtual DbSet<ServiceToMail> ServiceToMails { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<SmtpSetting> SmtpSettings { get; set; }

    public virtual DbSet<TaskCollection> TaskCollections { get; set; }

    public virtual DbSet<TaskExecuteRevision> TaskExecuteRevisions { get; set; }

    public virtual DbSet<TaskExecutionHistory> TaskExecutionHistories { get; set; }

    public virtual DbSet<TaskParameter> TaskParameters { get; set; }

    public virtual DbSet<TaskProject> TaskProjects { get; set; }

    public virtual DbSet<TaskServer> TaskServers { get; set; }

    public virtual DbSet<TaskSetting> TaskSettings { get; set; }

    public virtual DbSet<TaskSettingType> TaskSettingTypes { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<TemplateParameter> TemplateParameters { get; set; }

    public virtual DbSet<TemplateProject> TemplateProjects { get; set; }

    public virtual DbSet<TemplateServer> TemplateServers { get; set; }

    public virtual DbSet<TemplateSetting> TemplateSettings { get; set; }

    public virtual DbSet<TiaProject> TiaProjects { get; set; }

    public virtual DbSet<Trigger> Triggers { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    public virtual DbSet<WorkerAssignedLable> WorkerAssignedLables { get; set; }

    public virtual DbSet<WorkerLable> WorkerLables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlite("Data Source=F:\\repos\\Dispatcher-DB\\PsSuite.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActionParameter>(entity =>
        {
            entity.ToTable("ActionParameter");

            entity.HasIndex(e => e.ActionParameterId, "IX_ActionParameter_ActionParameterId").IsUnique();

            entity.Property(e => e.Key).HasColumnType("VARCHAR (20)");

            entity.HasOne(d => d.ActionParameterType).WithMany(p => p.ActionParameters).HasForeignKey(d => d.ActionParameterTypeId);
        });

        modelBuilder.Entity<ActionParameterType>(entity =>
        {
            entity.ToTable("ActionParameterType");

            entity.HasIndex(e => e.ActionParameterTypeId, "IX_ActionParameterType_ActionParameterTypeId").IsUnique();

            entity.Property(e => e.Key)
                .HasDefaultValue("KeyName")
                .HasColumnType("VARCHAR (20)");
            entity.Property(e => e.KeyAlias)
                .HasDefaultValue("KeyAlias")
                .HasColumnType("VARCHAR (20)");
            entity.Property(e => e.KeyCmd).HasColumnType("VARCHAR (20)");
            entity.Property(e => e.ToolTip)
                .HasDefaultValue("ToolTip")
                .HasColumnType("VARCHAR (1000)");
            entity.Property(e => e.Visibility).HasColumnType("INTEGER (1)");
        });

        modelBuilder.Entity<ActionScript>(entity =>
        {
            entity.ToTable("ActionScript");

            entity.HasIndex(e => e.ActionScriptId, "IX_ActionScript_ActionScriptId").IsUnique();

            entity.Property(e => e.ChangedAt)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.ChangedBy)
                .HasDefaultValueSql("0")
                .HasColumnType("VARCHAR (10)");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.CreatedBy)
                .HasDefaultValueSql("0")
                .HasColumnType("VARCHAR (10)");
            entity.Property(e => e.Description).HasColumnType("VARCHAR (500)");
            entity.Property(e => e.Extension).HasColumnType("VARCHAR (10)");
            entity.Property(e => e.Path)
                .HasDefaultValue("C:\\\\")
                .HasColumnType("VARCHAR (100)");
            entity.Property(e => e.ScriptName)
                .HasDefaultValue("script-name")
                .HasColumnType("VARCHAR (255)");
        });

        modelBuilder.Entity<MailNotification>(entity =>
        {
            entity.ToTable("MailNotification");

            entity.HasIndex(e => e.MailNotificationId, "IX_MailNotification_MailNotificationId").IsUnique();

            entity.Property(e => e.ActiveState).HasColumnType("INTEGER (1)");
            entity.Property(e => e.LockedState).HasColumnType("INTEGER (1)");
            entity.Property(e => e.MailName)
                .HasDefaultValue("MailName")
                .HasColumnType("VARCHAR (100)");
            entity.Property(e => e.MailTo)
                .HasDefaultValue("MailTo")
                .HasColumnType("VARCHAR (2000)");
            entity.Property(e => e.MarkForDelete).HasColumnType("INTEGER (1)");
        });

        modelBuilder.Entity<ProjectGroup>(entity =>
        {
            entity.ToTable("ProjectGroup");

            entity.HasIndex(e => e.ProjectGroupId, "IX_ProjectGroup_ProjectGroupId").IsUnique();

            entity.Property(e => e.Description).HasColumnType("VARCHAR (1000)");
            entity.Property(e => e.Name)
                .HasDefaultValue("group-name")
                .HasColumnType("VARCHAR (255)");

            entity.HasOne(d => d.ProjectServer).WithMany(p => p.ProjectGroups)
                .HasForeignKey(d => d.ProjectServerId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProjectServer>(entity =>
        {
            entity.ToTable("ProjectServer");

            entity.HasIndex(e => e.ProjectServerId, "IX_ProjectServer_ProjectServerId").IsUnique();

            entity.Property(e => e.Description).HasColumnType("VARCHAR (1000)");
            entity.Property(e => e.HostName)
                .HasDefaultValue("host-name")
                .HasColumnType("VARCHAR (255)");
            entity.Property(e => e.ServerName)
                .HasDefaultValue("server-name")
                .HasColumnType("VARCHAR (255)");
            entity.Property(e => e.ServerUrl)
                .HasDefaultValue("server-url")
                .HasColumnType("VARCHAR (500)");
        });

        modelBuilder.Entity<PssTask>(entity =>
        {
            entity.ToTable("PssTask");

            entity.HasIndex(e => e.PssTaskId, "IX_PssTask_PssTaskId").IsUnique();

            entity.Property(e => e.ActionScriptId).HasDefaultValue(0);
            entity.Property(e => e.ChangedAt)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.ChangedBy)
                .HasDefaultValueSql("0")
                .HasColumnType("VARCHAR (10)");
            entity.Property(e => e.CheckInMode).HasColumnType("VARCHAR (1)");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.CreatedBy)
                .HasDefaultValueSql("0")
                .HasColumnType("VARCHAR (10)");
            entity.Property(e => e.Description).HasColumnType("VARCHAR (1000)");
            entity.Property(e => e.Execution)
                .HasDefaultValue(1)
                .HasColumnType("INTEGER (10)");
            entity.Property(e => e.ExecutionFinished).HasColumnType("VARCHAR (14)");
            entity.Property(e => e.ExecutionStarted).HasColumnType("VARCHAR (14)");
            entity.Property(e => e.GroupName).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.Guid)
                .HasDefaultValue("00000000-0000-0000-0000-000000000000")
                .HasColumnType("VARCHAR (36)");
            entity.Property(e => e.Name)
                .HasDefaultValue("NewTask")
                .HasColumnType("VARCHAR (255)");
            entity.Property(e => e.Planned)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.ProjectName).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.RevisionOption).HasColumnType("VARCHAR (1)");
            entity.Property(e => e.ScheduleMode).HasColumnType("VARCHAR (1)");
            entity.Property(e => e.ServerName).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.ServerUrl).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.Status).HasColumnType("INTEGER (10)");
            entity.Property(e => e.TimeSchedule)
                .HasDefaultValue("00:01:00")
                .HasColumnType("VARCHAR (8)");
            entity.Property(e => e.TriggerMode).HasColumnType("VARCHAR (1)");
            entity.Property(e => e.Weekday).HasColumnType("VARCHAR (1)");

            entity.HasOne(d => d.ActionScript).WithMany(p => p.PssTasks).HasForeignKey(d => d.ActionScriptId);

            entity.HasOne(d => d.Template).WithMany(p => p.PssTasks)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PssWorkerLable>(entity =>
        {
            entity.ToTable("PssWorkerLable");

            entity.HasIndex(e => e.PssWorkerLableId, "IX_PssWorkerLable_PssWorkerLableId").IsUnique();

            entity.Property(e => e.Description).HasColumnType("VARCHAR (1000)");
            entity.Property(e => e.LableName)
                .HasDefaultValue("lable-name")
                .HasColumnType("VARCHAR (255)");
        });

        modelBuilder.Entity<Revision>(entity =>
        {
            entity.ToTable("Revision");

            entity.HasIndex(e => e.RevisionId, "IX_Revision_RevisionId").IsUnique();

            entity.Property(e => e.Author)
                .HasDefaultValue("author")
                .HasColumnType("VARCHAR (255)");
            entity.Property(e => e.LastModified)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.Modified)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.Notice)
                .HasDefaultValue("notice")
                .HasColumnType("VARCHAR (255)");
            entity.Property(e => e.RevisionHash).HasColumnType("VARCHAR (32)");
            entity.Property(e => e.Tested)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");

            entity.HasOne(d => d.TiaProject).WithMany(p => p.Revisions)
                .HasForeignKey(d => d.TiaProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ServiceNotification>(entity =>
        {
            entity.ToTable("ServiceNotification");

            entity.HasIndex(e => e.ServiceNotificationId, "IX_ServiceNotification_ServiceNotificationId").IsUnique();

            entity.Property(e => e.MailFrom)
                .HasDefaultValue("MailFrom")
                .HasColumnType("VARCHAR (2000)");
            entity.Property(e => e.MailSubject)
                .HasDefaultValue("MailSubject")
                .HasColumnType("VARCHAR (100)");
            entity.Property(e => e.ServiceName)
                .HasDefaultValue("ServiceName")
                .HasColumnType("VARCHAR (200)");
        });

        modelBuilder.Entity<ServiceToMail>(entity =>
        {
            entity.ToTable("ServiceToMail");

            entity.HasIndex(e => e.ServiceToMailId, "IX_ServiceToMail_ServiceToMailId").IsUnique();

            entity.HasOne(d => d.MailNotification).WithMany(p => p.ServiceToMails)
                .HasForeignKey(d => d.MailNotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ServiceNotification).WithMany(p => p.ServiceToMails)
                .HasForeignKey(d => d.ServiceNotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.ToTable("Setting");

            entity.HasIndex(e => e.SettingId, "IX_Setting_SettingId").IsUnique();

            entity.HasOne(d => d.TaskSettingType).WithMany(p => p.Settings).HasForeignKey(d => d.TaskSettingTypeId);
        });

        modelBuilder.Entity<SmtpSetting>(entity =>
        {
            entity.ToTable("SmtpSetting");

            entity.HasIndex(e => e.SmtpSettingId, "IX_SmtpSetting_SmtpSettingId").IsUnique();

            entity.Property(e => e.DeliveryFormat).HasDefaultValue(1);
            entity.Property(e => e.DeliveryTimeout).HasDefaultValue(100000);
            entity.Property(e => e.Description).HasColumnType("VARCHAR (2000)");
            entity.Property(e => e.Host)
                .HasDefaultValue("host-name")
                .HasColumnType("VARCHAR (255)");
            entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.SmtpPass).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.SslEnabled).HasDefaultValue(1);
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.User).HasColumnType("VARCHAR (255)");
        });

        modelBuilder.Entity<TaskCollection>(entity =>
        {
            entity.ToTable("TaskCollection");

            entity.HasIndex(e => e.TaskCollectionId, "IX_TaskCollection_TaskCollectionId").IsUnique();

            entity.HasOne(d => d.PssTask).WithMany(p => p.TaskCollections)
                .HasForeignKey(d => d.PssTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Template).WithMany(p => p.TaskCollections)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TaskExecuteRevision>(entity =>
        {
            entity.ToTable("TaskExecuteRevision");

            entity.HasIndex(e => e.TaskExecuteRevisionId, "IX_TaskExecuteRevision_TaskExecuteRevisionId").IsUnique();

            entity.Property(e => e.Status).HasColumnType("INTEGER (1)");

            entity.HasOne(d => d.PssTask).WithMany(p => p.TaskExecuteRevisions).HasForeignKey(d => d.PssTaskId);

            entity.HasOne(d => d.Revision).WithMany(p => p.TaskExecuteRevisions).HasForeignKey(d => d.RevisionId);
        });

        modelBuilder.Entity<TaskExecutionHistory>(entity =>
        {
            entity.ToTable("TaskExecutionHistory");

            entity.HasIndex(e => e.TaskExecutionHistoryId, "IX_TaskExecutionHistory_TaskExecutionHistoryId").IsUnique();

            entity.Property(e => e.ExecutionFinished).HasColumnType("VARCHAR (14)");
            entity.Property(e => e.ExecutionPlanned).HasColumnType("VARCHAR (14)");
            entity.Property(e => e.ExecutionStarted).HasColumnType("VARCHAR (14)");
            entity.Property(e => e.Guid).HasColumnType("VARCHAR (36)");
            entity.Property(e => e.ProjectName).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.ScriptConfiguration).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.ScriptName).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.ServerName).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.Status).HasColumnType("INTEGER (10)");
            entity.Property(e => e.TaskName).HasColumnType("VARCHAR (255)");
            entity.Property(e => e.TriggerMode).HasColumnType("VARCHAR (1)");

            entity.HasOne(d => d.PssTask).WithMany(p => p.TaskExecutionHistories).HasForeignKey(d => d.PssTaskId);
        });

        modelBuilder.Entity<TaskParameter>(entity =>
        {
            entity.ToTable("TaskParameter");

            entity.HasIndex(e => e.TaskParameterId, "IX_TaskParameter_TaskParameterId").IsUnique();

            entity.Property(e => e.ParameterValue).HasColumnType("VARCHAR (1000)");

            entity.HasOne(d => d.ActionParameter).WithMany(p => p.TaskParameters)
                .HasForeignKey(d => d.ActionParameterId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PssTask).WithMany(p => p.TaskParameters)
                .HasForeignKey(d => d.PssTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TaskProject>(entity =>
        {
            entity.ToTable("TaskProject");

            entity.HasIndex(e => e.TaskProjectId, "IX_TaskProject_TaskProjectId").IsUnique();

            entity.Property(e => e.Destination).HasColumnType("INTEGER (1)");

            entity.HasOne(d => d.PssTask).WithMany(p => p.TaskProjects)
                .HasForeignKey(d => d.PssTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TiaProject).WithMany(p => p.TaskProjects)
                .HasForeignKey(d => d.TiaProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TaskServer>(entity =>
        {
            entity.ToTable("TaskServer");

            entity.HasIndex(e => e.TaskServerId, "IX_TaskServer_TaskServerId").IsUnique();

            entity.Property(e => e.Destination).HasColumnType("INTEGER (1)");

            entity.HasOne(d => d.ProjectServer).WithMany(p => p.TaskServers)
                .HasForeignKey(d => d.ProjectServerId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PssTask).WithMany(p => p.TaskServers)
                .HasForeignKey(d => d.PssTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TaskSetting>(entity =>
        {
            entity.ToTable("TaskSetting");

            entity.HasIndex(e => e.TaskSettingId, "IX_TaskSetting_TaskSettingId").IsUnique();

            entity.HasOne(d => d.PssTask).WithMany(p => p.TaskSettings)
                .HasForeignKey(d => d.PssTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Setting).WithMany(p => p.TaskSettings)
                .HasForeignKey(d => d.SettingId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TaskSettingType>(entity =>
        {
            entity.ToTable("TaskSettingType");

            entity.HasIndex(e => e.TaskSettingTypeId, "IX_TaskSettingType_TaskSettingTypeId").IsUnique();

            entity.Property(e => e.Description).HasColumnType("VARCHAR (1000)");
            entity.Property(e => e.Name)
                .HasDefaultValue("TypeName")
                .HasColumnType("VARCHAR (50)");
        });

        modelBuilder.Entity<Template>(entity =>
        {
            entity.ToTable("Template");

            entity.HasIndex(e => e.TemplateId, "IX_Template_TemplateId").IsUnique();

            entity.Property(e => e.ChangedAt)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.ChangedBy)
                .HasDefaultValue("000000")
                .HasColumnType("VARCHAR (10)");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.CreatedBy)
                .HasDefaultValue("000000")
                .HasColumnType("VARCHAR (10)");
            entity.Property(e => e.Name)
                .HasDefaultValue("template-name")
                .HasColumnType("VARCHAR (255)");

            entity.HasOne(d => d.ActionScript).WithMany(p => p.Templates)
                .HasForeignKey(d => d.ActionScriptId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Trigger).WithMany(p => p.Templates)
                .HasForeignKey(d => d.TriggerId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TemplateParameter>(entity =>
        {
            entity.ToTable("TemplateParameter");

            entity.HasIndex(e => e.TemplateParameterId, "IX_TemplateParameter_TemplateParameterId").IsUnique();

            entity.Property(e => e.ParameterValue).HasColumnType("VARCHAR (1000)");

            entity.HasOne(d => d.ActionParameter).WithMany(p => p.TemplateParameters)
                .HasForeignKey(d => d.ActionParameterId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Template).WithMany(p => p.TemplateParameters)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TemplateProject>(entity =>
        {
            entity.ToTable("TemplateProject");

            entity.HasIndex(e => e.TemplateProjectId, "IX_TemplateProject_TemplateProjectId").IsUnique();

            entity.Property(e => e.Destination).HasColumnType("INTEGER (1)");

            entity.HasOne(d => d.Template).WithMany(p => p.TemplateProjects)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TiaProject).WithMany(p => p.TemplateProjects)
                .HasForeignKey(d => d.TiaProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TemplateServer>(entity =>
        {
            entity.ToTable("TemplateServer");

            entity.HasIndex(e => e.TemplateServerId, "IX_TemplateServer_TemplateServerId").IsUnique();

            entity.Property(e => e.Destination).HasColumnType("INTEGER (1)");

            entity.HasOne(d => d.ProjectServer).WithMany(p => p.TemplateServers)
                .HasForeignKey(d => d.ProjectServerId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Template).WithMany(p => p.TemplateServers)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TemplateSetting>(entity =>
        {
            entity.ToTable("TemplateSetting");

            entity.HasIndex(e => e.TemplateSettingId, "IX_TemplateSetting_TemplateSettingId").IsUnique();

            entity.HasOne(d => d.Setting).WithMany(p => p.TemplateSettings)
                .HasForeignKey(d => d.SettingId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Template).WithMany(p => p.TemplateSettings)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TiaProject>(entity =>
        {
            entity.ToTable("TiaProject");

            entity.HasIndex(e => e.TiaProjectId, "IX_TiaProject_TiaProjectId").IsUnique();

            entity.Property(e => e.ChangedAt)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.ChangedBy)
                .HasDefaultValue("000000")
                .HasColumnType("VARCHAR (10)");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValue("20221231235960")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.CreatedBy)
                .HasDefaultValue("000000")
                .HasColumnType("VARCHAR (10)");
            entity.Property(e => e.Description).HasColumnType("VARCHAR (1000)");
            entity.Property(e => e.ProjectName)
                .HasDefaultValue("project-name")
                .HasColumnType("VARCHAR (255)");
            entity.Property(e => e.ProjectType)
                .HasDefaultValue("project")
                .HasColumnType("VARCHAR (50)");
            entity.Property(e => e.ProjectVersion)
                .HasDefaultValue("0.0.0.0")
                .HasColumnType("VARCHAR (15)");

            entity.HasOne(d => d.ProjectGroup).WithMany(p => p.TiaProjects)
                .HasForeignKey(d => d.ProjectGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ProjectServer).WithMany(p => p.TiaProjects)
                .HasForeignKey(d => d.ProjectServerId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Trigger>(entity =>
        {
            entity.ToTable("Trigger");

            entity.HasIndex(e => e.TriggerId, "IX_Trigger_TriggerId").IsUnique();

            entity.Property(e => e.TimeSchedule).HasColumnType("VARCHAR (8)");
            entity.Property(e => e.TriggerMode).HasDefaultValue(1);
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.ToTable("Worker");

            entity.HasIndex(e => e.WorkerId, "IX_Worker_WorkerId").IsUnique();

            entity.Property(e => e.Description).HasColumnType("VARCHAR (1000)");
            entity.Property(e => e.KeepAlive)
                .HasDefaultValue("19000101000000")
                .HasColumnType("VARCHAR (14)");
            entity.Property(e => e.WorkerName)
                .HasDefaultValue("worker-name")
                .HasColumnType("VARCHAR (255)");
        });

        modelBuilder.Entity<WorkerAssignedLable>(entity =>
        {
            entity.ToTable("WorkerAssignedLable");

            entity.HasIndex(e => e.WorkerAssignedLableId, "IX_WorkerAssignedLable_WorkerAssignedLableId").IsUnique();

            entity.HasOne(d => d.Worker).WithMany(p => p.WorkerAssignedLables)
                .HasForeignKey(d => d.WorkerId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.WorkerLable).WithMany(p => p.WorkerAssignedLables)
                .HasForeignKey(d => d.WorkerLableId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<WorkerLable>(entity =>
        {
            entity.ToTable("WorkerLable");

            entity.HasIndex(e => e.WorkerLableId, "IX_WorkerLable_WorkerLableId").IsUnique();

            entity.Property(e => e.Description).HasColumnType("VARCHAR (1000)");
            entity.Property(e => e.LableName)
                .HasDefaultValue("lable-name")
                .HasColumnType("VARCHAR (255)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
