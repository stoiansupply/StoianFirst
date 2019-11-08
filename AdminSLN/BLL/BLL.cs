 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBLL;

namespace BLL
{
    public partial class FILTERBLL : BaseBLL<Model.FILTER>,IFILTERBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IFILTERDAL;
		}
    }
    public partial class GROUPBLL : BaseBLL<Model.GROUP>,IGROUPBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IGROUPDAL;
		}
    }
    public partial class INCIDENTBLL : BaseBLL<Model.INCIDENT>,IINCIDENTBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IINCIDENTDAL;
		}
    }
    public partial class INCIDENTS_ARCHIVEBLL : BaseBLL<Model.INCIDENTS_ARCHIVE>,IINCIDENTS_ARCHIVEBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IINCIDENTS_ARCHIVEDAL;
		}
    }
    public partial class INCIDENTS_BAKBLL : BaseBLL<Model.INCIDENTS_BAK>,IINCIDENTS_BAKBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IINCIDENTS_BAKDAL;
		}
    }
    public partial class LOGACTIONBLL : BaseBLL<Model.LOGACTION>,ILOGACTIONBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ILOGACTIONDAL;
		}
    }
    public partial class LOGACTIONS_ARCHIVEBLL : BaseBLL<Model.LOGACTIONS_ARCHIVE>,ILOGACTIONS_ARCHIVEBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ILOGACTIONS_ARCHIVEDAL;
		}
    }
    public partial class LOGACTIONS_BAKBLL : BaseBLL<Model.LOGACTIONS_BAK>,ILOGACTIONS_BAKBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ILOGACTIONS_BAKDAL;
		}
    }
    public partial class LOGEVENTBLL : BaseBLL<Model.LOGEVENT>,ILOGEVENTBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ILOGEVENTDAL;
		}
    }
    public partial class LOGEVENTS_ARCHIVEBLL : BaseBLL<Model.LOGEVENTS_ARCHIVE>,ILOGEVENTS_ARCHIVEBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ILOGEVENTS_ARCHIVEDAL;
		}
    }
    public partial class LOGEVENTS_BAKBLL : BaseBLL<Model.LOGEVENTS_BAK>,ILOGEVENTS_BAKBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ILOGEVENTS_BAKDAL;
		}
    }
    public partial class MEMBERBLL : BaseBLL<Model.MEMBER>,IMEMBERBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IMEMBERDAL;
		}
    }
    public partial class PROCESSBLL : BaseBLL<Model.PROCESS>,IPROCESSBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IPROCESSDAL;
		}
    }
    public partial class PROCESSACCESSRIGHTBLL : BaseBLL<Model.PROCESSACCESSRIGHT>,IPROCESSACCESSRIGHTBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IPROCESSACCESSRIGHTDAL;
		}
    }
    public partial class PROCESSCONFIGURATIONBLL : BaseBLL<Model.PROCESSCONFIGURATION>,IPROCESSCONFIGURATIONBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IPROCESSCONFIGURATIONDAL;
		}
    }
    public partial class PROCESSSTEPBLL : BaseBLL<Model.PROCESSSTEP>,IPROCESSSTEPBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IPROCESSSTEPDAL;
		}
    }
    public partial class REPORTSRIGHTBLL : BaseBLL<Model.REPORTSRIGHT>,IREPORTSRIGHTBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IREPORTSRIGHTDAL;
		}
    }
    public partial class SERVERPREFERENCEBLL : BaseBLL<Model.SERVERPREFERENCE>,ISERVERPREFERENCEBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ISERVERPREFERENCEDAL;
		}
    }
    public partial class STEPACTIVATIONIDBLL : BaseBLL<Model.STEPACTIVATIONID>,ISTEPACTIVATIONIDBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ISTEPACTIVATIONIDDAL;
		}
    }
    public partial class STEPACTIVATIONSYNCBLL : BaseBLL<Model.STEPACTIVATIONSYNC>,ISTEPACTIVATIONSYNCBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ISTEPACTIVATIONSYNCDAL;
		}
    }
    public partial class StudioConfig_AccessRightsBLL : BaseBLL<Model.StudioConfig_AccessRights>,IStudioConfig_AccessRightsBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IStudioConfig_AccessRightsDAL;
		}
    }
    public partial class StudioConfig_DomainsBLL : BaseBLL<Model.StudioConfig_Domains>,IStudioConfig_DomainsBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IStudioConfig_DomainsDAL;
		}
    }
    public partial class StudioConfig_LDAPDomainsBLL : BaseBLL<Model.StudioConfig_LDAPDomains>,IStudioConfig_LDAPDomainsBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IStudioConfig_LDAPDomainsDAL;
		}
    }
    public partial class StudioConfig_RepositoriesBLL : BaseBLL<Model.StudioConfig_Repositories>,IStudioConfig_RepositoriesBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IStudioConfig_RepositoriesDAL;
		}
    }
    public partial class StudioConfig_ServersBLL : BaseBLL<Model.StudioConfig_Servers>,IStudioConfig_ServersBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IStudioConfig_ServersDAL;
		}
    }
    public partial class StudioConfig_UserRepositoriesBLL : BaseBLL<Model.StudioConfig_UserRepositories>,IStudioConfig_UserRepositoriesBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IStudioConfig_UserRepositoriesDAL;
		}
    }
    public partial class StudioConfig_UsersBLL : BaseBLL<Model.StudioConfig_Users>,IStudioConfig_UsersBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IStudioConfig_UsersDAL;
		}
    }
    public partial class StudioConfig_UserServersBLL : BaseBLL<Model.StudioConfig_UserServers>,IStudioConfig_UserServersBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IStudioConfig_UserServersDAL;
		}
    }
    public partial class SUBPROCBLL : BaseBLL<Model.SUBPROC>,ISUBPROCBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ISUBPROCDAL;
		}
    }
    public partial class T_BPM_AWOKE_SETBLL : BaseBLL<Model.T_BPM_AWOKE_SET>,IT_BPM_AWOKE_SETBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IT_BPM_AWOKE_SETDAL;
		}
    }
    public partial class T_BPM_PRC_APPROVALBLL : BaseBLL<Model.T_BPM_PRC_APPROVAL>,IT_BPM_PRC_APPROVALBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IT_BPM_PRC_APPROVALDAL;
		}
    }
    public partial class T_BPM_PRC_RGTBLL : BaseBLL<Model.T_BPM_PRC_RGT>,IT_BPM_PRC_RGTBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IT_BPM_PRC_RGTDAL;
		}
    }
    public partial class T_BPM_PRCCLASS_LINKBLL : BaseBLL<Model.T_BPM_PRCCLASS_LINK>,IT_BPM_PRCCLASS_LINKBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IT_BPM_PRCCLASS_LINKDAL;
		}
    }
    public partial class T_BPM_PROCESSCLASSBLL : BaseBLL<Model.T_BPM_PROCESSCLASS>,IT_BPM_PROCESSCLASSBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IT_BPM_PROCESSCLASSDAL;
		}
    }
    public partial class T_BPM_PROCESSCLASS_C_USERBLL : BaseBLL<Model.T_BPM_PROCESSCLASS_C_USER>,IT_BPM_PROCESSCLASS_C_USERBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IT_BPM_PROCESSCLASS_C_USERDAL;
		}
    }
    public partial class T_BPM_PROCESSCLASS_RIGHT_LINKBLL : BaseBLL<Model.T_BPM_PROCESSCLASS_RIGHT_LINK>,IT_BPM_PROCESSCLASS_RIGHT_LINKBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IT_BPM_PROCESSCLASS_RIGHT_LINKDAL;
		}
    }
    public partial class T_BPM_READ_KNOWBLL : BaseBLL<Model.T_BPM_READ_KNOW>,IT_BPM_READ_KNOWBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IT_BPM_READ_KNOWDAL;
		}
    }
    public partial class T_BPM_SYSTEM_SETBLL : BaseBLL<Model.T_BPM_SYSTEM_SET>,IT_BPM_SYSTEM_SETBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IT_BPM_SYSTEM_SETDAL;
		}
    }
    public partial class T_BPM_TASK_AUTOASSIGNEDBLL : BaseBLL<Model.T_BPM_TASK_AUTOASSIGNED>,IT_BPM_TASK_AUTOASSIGNEDBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IT_BPM_TASK_AUTOASSIGNEDDAL;
		}
    }
    public partial class TASKBLL : BaseBLL<Model.TASK>,ITASKBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ITASKDAL;
		}
    }
    public partial class TASKQUEUEBLL : BaseBLL<Model.TASKQUEUE>,ITASKQUEUEBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ITASKQUEUEDAL;
		}
    }
    public partial class TASKS_ARCHIVEBLL : BaseBLL<Model.TASKS_ARCHIVE>,ITASKS_ARCHIVEBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ITASKS_ARCHIVEDAL;
		}
    }
    public partial class TASKS_BAKBLL : BaseBLL<Model.TASKS_BAK>,ITASKS_BAKBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ITASKS_BAKDAL;
		}
    }
    public partial class TRUSTEDUSERBLL : BaseBLL<Model.TRUSTEDUSER>,ITRUSTEDUSERBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.ITRUSTEDUSERDAL;
		}
    }
    public partial class ULTIMUSREPALERTBLL : BaseBLL<Model.ULTIMUSREPALERT>,IULTIMUSREPALERTBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IULTIMUSREPALERTDAL;
		}
    }
    public partial class ULTIMUSREPORTBLL : BaseBLL<Model.ULTIMUSREPORT>,IULTIMUSREPORTBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IULTIMUSREPORTDAL;
		}
    }
    public partial class ULTVIEWBLL : BaseBLL<Model.ULTVIEW>,IULTVIEWBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IULTVIEWDAL;
		}
    }
    public partial class USERSERVERPREFERENCEBLL : BaseBLL<Model.USERSERVERPREFERENCE>,IUSERSERVERPREFERENCEBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IUSERSERVERPREFERENCEDAL;
		}
    }
    public partial class VIEWFOLDERBLL : BaseBLL<Model.VIEWFOLDER>,IVIEWFOLDERBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IVIEWFOLDERDAL;
		}
    }
}
