using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;

namespace DAL
{
    public partial class FILTERDAL : BaseDAL<Model.FILTER>,IFILTERDAL
    {
    }
    public partial class GROUPDAL : BaseDAL<Model.GROUP>,IGROUPDAL
    {
    }
    public partial class INCIDENTDAL : BaseDAL<Model.INCIDENT>,IINCIDENTDAL
    {
    }
    public partial class INCIDENTS_ARCHIVEDAL : BaseDAL<Model.INCIDENTS_ARCHIVE>,IINCIDENTS_ARCHIVEDAL
    {
    }
    public partial class INCIDENTS_BAKDAL : BaseDAL<Model.INCIDENTS_BAK>,IINCIDENTS_BAKDAL
    {
    }
    public partial class LOGACTIONDAL : BaseDAL<Model.LOGACTION>,ILOGACTIONDAL
    {
    }
    public partial class LOGACTIONS_ARCHIVEDAL : BaseDAL<Model.LOGACTIONS_ARCHIVE>,ILOGACTIONS_ARCHIVEDAL
    {
    }
    public partial class LOGACTIONS_BAKDAL : BaseDAL<Model.LOGACTIONS_BAK>,ILOGACTIONS_BAKDAL
    {
    }
    public partial class LOGEVENTDAL : BaseDAL<Model.LOGEVENT>,ILOGEVENTDAL
    {
    }
    public partial class LOGEVENTS_ARCHIVEDAL : BaseDAL<Model.LOGEVENTS_ARCHIVE>,ILOGEVENTS_ARCHIVEDAL
    {
    }
    public partial class LOGEVENTS_BAKDAL : BaseDAL<Model.LOGEVENTS_BAK>,ILOGEVENTS_BAKDAL
    {
    }
    public partial class MEMBERDAL : BaseDAL<Model.MEMBER>,IMEMBERDAL
    {
    }
    public partial class PROCESSDAL : BaseDAL<Model.PROCESS>,IPROCESSDAL
    {
    }
    public partial class PROCESSACCESSRIGHTDAL : BaseDAL<Model.PROCESSACCESSRIGHT>,IPROCESSACCESSRIGHTDAL
    {
    }
    public partial class PROCESSCONFIGURATIONDAL : BaseDAL<Model.PROCESSCONFIGURATION>,IPROCESSCONFIGURATIONDAL
    {
    }
    public partial class PROCESSSTEPDAL : BaseDAL<Model.PROCESSSTEP>,IPROCESSSTEPDAL
    {
    }
    public partial class REPORTSRIGHTDAL : BaseDAL<Model.REPORTSRIGHT>,IREPORTSRIGHTDAL
    {
    }
    public partial class SERVERPREFERENCEDAL : BaseDAL<Model.SERVERPREFERENCE>,ISERVERPREFERENCEDAL
    {
    }
    public partial class STEPACTIVATIONIDDAL : BaseDAL<Model.STEPACTIVATIONID>,ISTEPACTIVATIONIDDAL
    {
    }
    public partial class STEPACTIVATIONSYNCDAL : BaseDAL<Model.STEPACTIVATIONSYNC>,ISTEPACTIVATIONSYNCDAL
    {
    }
    public partial class StudioConfig_AccessRightsDAL : BaseDAL<Model.StudioConfig_AccessRights>,IStudioConfig_AccessRightsDAL
    {
    }
    public partial class StudioConfig_DomainsDAL : BaseDAL<Model.StudioConfig_Domains>,IStudioConfig_DomainsDAL
    {
    }
    public partial class StudioConfig_LDAPDomainsDAL : BaseDAL<Model.StudioConfig_LDAPDomains>,IStudioConfig_LDAPDomainsDAL
    {
    }
    public partial class StudioConfig_RepositoriesDAL : BaseDAL<Model.StudioConfig_Repositories>,IStudioConfig_RepositoriesDAL
    {
    }
    public partial class StudioConfig_ServersDAL : BaseDAL<Model.StudioConfig_Servers>,IStudioConfig_ServersDAL
    {
    }
    public partial class StudioConfig_UserRepositoriesDAL : BaseDAL<Model.StudioConfig_UserRepositories>,IStudioConfig_UserRepositoriesDAL
    {
    }
    public partial class StudioConfig_UsersDAL : BaseDAL<Model.StudioConfig_Users>,IStudioConfig_UsersDAL
    {
    }
    public partial class StudioConfig_UserServersDAL : BaseDAL<Model.StudioConfig_UserServers>,IStudioConfig_UserServersDAL
    {
    }
    public partial class SUBPROCDAL : BaseDAL<Model.SUBPROC>,ISUBPROCDAL
    {
    }
    public partial class T_BPM_AWOKE_SETDAL : BaseDAL<Model.T_BPM_AWOKE_SET>,IT_BPM_AWOKE_SETDAL
    {
    }
    public partial class T_BPM_PRC_APPROVALDAL : BaseDAL<Model.T_BPM_PRC_APPROVAL>,IT_BPM_PRC_APPROVALDAL
    {
    }
    public partial class T_BPM_PRC_RGTDAL : BaseDAL<Model.T_BPM_PRC_RGT>,IT_BPM_PRC_RGTDAL
    {
    }
    public partial class T_BPM_PRCCLASS_LINKDAL : BaseDAL<Model.T_BPM_PRCCLASS_LINK>,IT_BPM_PRCCLASS_LINKDAL
    {
    }
    public partial class T_BPM_PROCESSCLASSDAL : BaseDAL<Model.T_BPM_PROCESSCLASS>,IT_BPM_PROCESSCLASSDAL
    {
    }
    public partial class T_BPM_PROCESSCLASS_C_USERDAL : BaseDAL<Model.T_BPM_PROCESSCLASS_C_USER>,IT_BPM_PROCESSCLASS_C_USERDAL
    {
    }
    public partial class T_BPM_PROCESSCLASS_RIGHT_LINKDAL : BaseDAL<Model.T_BPM_PROCESSCLASS_RIGHT_LINK>,IT_BPM_PROCESSCLASS_RIGHT_LINKDAL
    {
    }
    public partial class T_BPM_READ_KNOWDAL : BaseDAL<Model.T_BPM_READ_KNOW>,IT_BPM_READ_KNOWDAL
    {
    }
    public partial class T_BPM_SYSTEM_SETDAL : BaseDAL<Model.T_BPM_SYSTEM_SET>,IT_BPM_SYSTEM_SETDAL
    {
    }
    public partial class T_BPM_TASK_AUTOASSIGNEDDAL : BaseDAL<Model.T_BPM_TASK_AUTOASSIGNED>,IT_BPM_TASK_AUTOASSIGNEDDAL
    {
    }
    public partial class TASKDAL : BaseDAL<Model.TASK>,ITASKDAL
    {
    }
    public partial class TASKQUEUEDAL : BaseDAL<Model.TASKQUEUE>,ITASKQUEUEDAL
    {
    }
    public partial class TASKS_ARCHIVEDAL : BaseDAL<Model.TASKS_ARCHIVE>,ITASKS_ARCHIVEDAL
    {
    }
    public partial class TASKS_BAKDAL : BaseDAL<Model.TASKS_BAK>,ITASKS_BAKDAL
    {
    }
    public partial class TRUSTEDUSERDAL : BaseDAL<Model.TRUSTEDUSER>,ITRUSTEDUSERDAL
    {
    }
    public partial class ULTIMUSREPALERTDAL : BaseDAL<Model.ULTIMUSREPALERT>,IULTIMUSREPALERTDAL
    {
    }
    public partial class ULTIMUSREPORTDAL : BaseDAL<Model.ULTIMUSREPORT>,IULTIMUSREPORTDAL
    {
    }
    public partial class ULTVIEWDAL : BaseDAL<Model.ULTVIEW>,IULTVIEWDAL
    {
    }
    public partial class USERSERVERPREFERENCEDAL : BaseDAL<Model.USERSERVERPREFERENCE>,IUSERSERVERPREFERENCEDAL
    {
    }
    public partial class VIEWFOLDERDAL : BaseDAL<Model.VIEWFOLDER>,IVIEWFOLDERDAL
    {
    }
}
