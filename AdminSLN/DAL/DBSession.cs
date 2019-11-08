using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;

namespace DAL
{
    public partial class DBSession : IDBSession
    {
        #region 1 数据接口 IFILTERDAL
        IFILTERDAL iFILTERDAL;
        public IFILTERDAL IFILTERDAL
        {
            get
            {
                if (iFILTERDAL == null)
                    iFILTERDAL = new FILTERDAL();
                return iFILTERDAL;
            }
            set
            {
                iFILTERDAL = value;
            }
        }
        #endregion
        #region 2 数据接口 IGROUPDAL
        IGROUPDAL iGROUPDAL;
        public IGROUPDAL IGROUPDAL
        {
            get
            {
                if (iGROUPDAL == null)
                    iGROUPDAL = new GROUPDAL();
                return iGROUPDAL;
            }
            set
            {
                iGROUPDAL = value;
            }
        }
        #endregion
        #region 3 数据接口 IINCIDENTDAL
        IINCIDENTDAL iINCIDENTDAL;
        public IINCIDENTDAL IINCIDENTDAL
        {
            get
            {
                if (iINCIDENTDAL == null)
                    iINCIDENTDAL = new INCIDENTDAL();
                return iINCIDENTDAL;
            }
            set
            {
                iINCIDENTDAL = value;
            }
        }
        #endregion
        #region 4 数据接口 IINCIDENTS_ARCHIVEDAL
        IINCIDENTS_ARCHIVEDAL iINCIDENTS_ARCHIVEDAL;
        public IINCIDENTS_ARCHIVEDAL IINCIDENTS_ARCHIVEDAL
        {
            get
            {
                if (iINCIDENTS_ARCHIVEDAL == null)
                    iINCIDENTS_ARCHIVEDAL = new INCIDENTS_ARCHIVEDAL();
                return iINCIDENTS_ARCHIVEDAL;
            }
            set
            {
                iINCIDENTS_ARCHIVEDAL = value;
            }
        }
        #endregion
        #region 5 数据接口 IINCIDENTS_BAKDAL
        IINCIDENTS_BAKDAL iINCIDENTS_BAKDAL;
        public IINCIDENTS_BAKDAL IINCIDENTS_BAKDAL
        {
            get
            {
                if (iINCIDENTS_BAKDAL == null)
                    iINCIDENTS_BAKDAL = new INCIDENTS_BAKDAL();
                return iINCIDENTS_BAKDAL;
            }
            set
            {
                iINCIDENTS_BAKDAL = value;
            }
        }
        #endregion
        #region 6 数据接口 ILOGACTIONDAL
        ILOGACTIONDAL iLOGACTIONDAL;
        public ILOGACTIONDAL ILOGACTIONDAL
        {
            get
            {
                if (iLOGACTIONDAL == null)
                    iLOGACTIONDAL = new LOGACTIONDAL();
                return iLOGACTIONDAL;
            }
            set
            {
                iLOGACTIONDAL = value;
            }
        }
        #endregion
        #region 7 数据接口 ILOGACTIONS_ARCHIVEDAL
        ILOGACTIONS_ARCHIVEDAL iLOGACTIONS_ARCHIVEDAL;
        public ILOGACTIONS_ARCHIVEDAL ILOGACTIONS_ARCHIVEDAL
        {
            get
            {
                if (iLOGACTIONS_ARCHIVEDAL == null)
                    iLOGACTIONS_ARCHIVEDAL = new LOGACTIONS_ARCHIVEDAL();
                return iLOGACTIONS_ARCHIVEDAL;
            }
            set
            {
                iLOGACTIONS_ARCHIVEDAL = value;
            }
        }
        #endregion
        #region 8 数据接口 ILOGACTIONS_BAKDAL
        ILOGACTIONS_BAKDAL iLOGACTIONS_BAKDAL;
        public ILOGACTIONS_BAKDAL ILOGACTIONS_BAKDAL
        {
            get
            {
                if (iLOGACTIONS_BAKDAL == null)
                    iLOGACTIONS_BAKDAL = new LOGACTIONS_BAKDAL();
                return iLOGACTIONS_BAKDAL;
            }
            set
            {
                iLOGACTIONS_BAKDAL = value;
            }
        }
        #endregion
        #region 9 数据接口 ILOGEVENTDAL
        ILOGEVENTDAL iLOGEVENTDAL;
        public ILOGEVENTDAL ILOGEVENTDAL
        {
            get
            {
                if (iLOGEVENTDAL == null)
                    iLOGEVENTDAL = new LOGEVENTDAL();
                return iLOGEVENTDAL;
            }
            set
            {
                iLOGEVENTDAL = value;
            }
        }
        #endregion
        #region 10 数据接口 ILOGEVENTS_ARCHIVEDAL
        ILOGEVENTS_ARCHIVEDAL iLOGEVENTS_ARCHIVEDAL;
        public ILOGEVENTS_ARCHIVEDAL ILOGEVENTS_ARCHIVEDAL
        {
            get
            {
                if (iLOGEVENTS_ARCHIVEDAL == null)
                    iLOGEVENTS_ARCHIVEDAL = new LOGEVENTS_ARCHIVEDAL();
                return iLOGEVENTS_ARCHIVEDAL;
            }
            set
            {
                iLOGEVENTS_ARCHIVEDAL = value;
            }
        }
        #endregion
        #region 11 数据接口 ILOGEVENTS_BAKDAL
        ILOGEVENTS_BAKDAL iLOGEVENTS_BAKDAL;
        public ILOGEVENTS_BAKDAL ILOGEVENTS_BAKDAL
        {
            get
            {
                if (iLOGEVENTS_BAKDAL == null)
                    iLOGEVENTS_BAKDAL = new LOGEVENTS_BAKDAL();
                return iLOGEVENTS_BAKDAL;
            }
            set
            {
                iLOGEVENTS_BAKDAL = value;
            }
        }
        #endregion
        #region 12 数据接口 IMEMBERDAL
        IMEMBERDAL iMEMBERDAL;
        public IMEMBERDAL IMEMBERDAL
        {
            get
            {
                if (iMEMBERDAL == null)
                    iMEMBERDAL = new MEMBERDAL();
                return iMEMBERDAL;
            }
            set
            {
                iMEMBERDAL = value;
            }
        }
        #endregion
        #region 13 数据接口 IPROCESSDAL
        IPROCESSDAL iPROCESSDAL;
        public IPROCESSDAL IPROCESSDAL
        {
            get
            {
                if (iPROCESSDAL == null)
                    iPROCESSDAL = new PROCESSDAL();
                return iPROCESSDAL;
            }
            set
            {
                iPROCESSDAL = value;
            }
        }
        #endregion
        #region 14 数据接口 IPROCESSACCESSRIGHTDAL
        IPROCESSACCESSRIGHTDAL iPROCESSACCESSRIGHTDAL;
        public IPROCESSACCESSRIGHTDAL IPROCESSACCESSRIGHTDAL
        {
            get
            {
                if (iPROCESSACCESSRIGHTDAL == null)
                    iPROCESSACCESSRIGHTDAL = new PROCESSACCESSRIGHTDAL();
                return iPROCESSACCESSRIGHTDAL;
            }
            set
            {
                iPROCESSACCESSRIGHTDAL = value;
            }
        }
        #endregion
        #region 15 数据接口 IPROCESSCONFIGURATIONDAL
        IPROCESSCONFIGURATIONDAL iPROCESSCONFIGURATIONDAL;
        public IPROCESSCONFIGURATIONDAL IPROCESSCONFIGURATIONDAL
        {
            get
            {
                if (iPROCESSCONFIGURATIONDAL == null)
                    iPROCESSCONFIGURATIONDAL = new PROCESSCONFIGURATIONDAL();
                return iPROCESSCONFIGURATIONDAL;
            }
            set
            {
                iPROCESSCONFIGURATIONDAL = value;
            }
        }
        #endregion
        #region 16 数据接口 IPROCESSSTEPDAL
        IPROCESSSTEPDAL iPROCESSSTEPDAL;
        public IPROCESSSTEPDAL IPROCESSSTEPDAL
        {
            get
            {
                if (iPROCESSSTEPDAL == null)
                    iPROCESSSTEPDAL = new PROCESSSTEPDAL();
                return iPROCESSSTEPDAL;
            }
            set
            {
                iPROCESSSTEPDAL = value;
            }
        }
        #endregion
        #region 17 数据接口 IREPORTSRIGHTDAL
        IREPORTSRIGHTDAL iREPORTSRIGHTDAL;
        public IREPORTSRIGHTDAL IREPORTSRIGHTDAL
        {
            get
            {
                if (iREPORTSRIGHTDAL == null)
                    iREPORTSRIGHTDAL = new REPORTSRIGHTDAL();
                return iREPORTSRIGHTDAL;
            }
            set
            {
                iREPORTSRIGHTDAL = value;
            }
        }
        #endregion
        #region 18 数据接口 ISERVERPREFERENCEDAL
        ISERVERPREFERENCEDAL iSERVERPREFERENCEDAL;
        public ISERVERPREFERENCEDAL ISERVERPREFERENCEDAL
        {
            get
            {
                if (iSERVERPREFERENCEDAL == null)
                    iSERVERPREFERENCEDAL = new SERVERPREFERENCEDAL();
                return iSERVERPREFERENCEDAL;
            }
            set
            {
                iSERVERPREFERENCEDAL = value;
            }
        }
        #endregion
        #region 19 数据接口 ISTEPACTIVATIONIDDAL
        ISTEPACTIVATIONIDDAL iSTEPACTIVATIONIDDAL;
        public ISTEPACTIVATIONIDDAL ISTEPACTIVATIONIDDAL
        {
            get
            {
                if (iSTEPACTIVATIONIDDAL == null)
                    iSTEPACTIVATIONIDDAL = new STEPACTIVATIONIDDAL();
                return iSTEPACTIVATIONIDDAL;
            }
            set
            {
                iSTEPACTIVATIONIDDAL = value;
            }
        }
        #endregion
        #region 20 数据接口 ISTEPACTIVATIONSYNCDAL
        ISTEPACTIVATIONSYNCDAL iSTEPACTIVATIONSYNCDAL;
        public ISTEPACTIVATIONSYNCDAL ISTEPACTIVATIONSYNCDAL
        {
            get
            {
                if (iSTEPACTIVATIONSYNCDAL == null)
                    iSTEPACTIVATIONSYNCDAL = new STEPACTIVATIONSYNCDAL();
                return iSTEPACTIVATIONSYNCDAL;
            }
            set
            {
                iSTEPACTIVATIONSYNCDAL = value;
            }
        }
        #endregion
        #region 21 数据接口 IStudioConfig_AccessRightsDAL
        IStudioConfig_AccessRightsDAL iStudioConfig_AccessRightsDAL;
        public IStudioConfig_AccessRightsDAL IStudioConfig_AccessRightsDAL
        {
            get
            {
                if (iStudioConfig_AccessRightsDAL == null)
                    iStudioConfig_AccessRightsDAL = new StudioConfig_AccessRightsDAL();
                return iStudioConfig_AccessRightsDAL;
            }
            set
            {
                iStudioConfig_AccessRightsDAL = value;
            }
        }
        #endregion
        #region 22 数据接口 IStudioConfig_DomainsDAL
        IStudioConfig_DomainsDAL iStudioConfig_DomainsDAL;
        public IStudioConfig_DomainsDAL IStudioConfig_DomainsDAL
        {
            get
            {
                if (iStudioConfig_DomainsDAL == null)
                    iStudioConfig_DomainsDAL = new StudioConfig_DomainsDAL();
                return iStudioConfig_DomainsDAL;
            }
            set
            {
                iStudioConfig_DomainsDAL = value;
            }
        }
        #endregion
        #region 23 数据接口 IStudioConfig_LDAPDomainsDAL
        IStudioConfig_LDAPDomainsDAL iStudioConfig_LDAPDomainsDAL;
        public IStudioConfig_LDAPDomainsDAL IStudioConfig_LDAPDomainsDAL
        {
            get
            {
                if (iStudioConfig_LDAPDomainsDAL == null)
                    iStudioConfig_LDAPDomainsDAL = new StudioConfig_LDAPDomainsDAL();
                return iStudioConfig_LDAPDomainsDAL;
            }
            set
            {
                iStudioConfig_LDAPDomainsDAL = value;
            }
        }
        #endregion
        #region 24 数据接口 IStudioConfig_RepositoriesDAL
        IStudioConfig_RepositoriesDAL iStudioConfig_RepositoriesDAL;
        public IStudioConfig_RepositoriesDAL IStudioConfig_RepositoriesDAL
        {
            get
            {
                if (iStudioConfig_RepositoriesDAL == null)
                    iStudioConfig_RepositoriesDAL = new StudioConfig_RepositoriesDAL();
                return iStudioConfig_RepositoriesDAL;
            }
            set
            {
                iStudioConfig_RepositoriesDAL = value;
            }
        }
        #endregion
        #region 25 数据接口 IStudioConfig_ServersDAL
        IStudioConfig_ServersDAL iStudioConfig_ServersDAL;
        public IStudioConfig_ServersDAL IStudioConfig_ServersDAL
        {
            get
            {
                if (iStudioConfig_ServersDAL == null)
                    iStudioConfig_ServersDAL = new StudioConfig_ServersDAL();
                return iStudioConfig_ServersDAL;
            }
            set
            {
                iStudioConfig_ServersDAL = value;
            }
        }
        #endregion
        #region 26 数据接口 IStudioConfig_UserRepositoriesDAL
        IStudioConfig_UserRepositoriesDAL iStudioConfig_UserRepositoriesDAL;
        public IStudioConfig_UserRepositoriesDAL IStudioConfig_UserRepositoriesDAL
        {
            get
            {
                if (iStudioConfig_UserRepositoriesDAL == null)
                    iStudioConfig_UserRepositoriesDAL = new StudioConfig_UserRepositoriesDAL();
                return iStudioConfig_UserRepositoriesDAL;
            }
            set
            {
                iStudioConfig_UserRepositoriesDAL = value;
            }
        }
        #endregion
        #region 27 数据接口 IStudioConfig_UsersDAL
        IStudioConfig_UsersDAL iStudioConfig_UsersDAL;
        public IStudioConfig_UsersDAL IStudioConfig_UsersDAL
        {
            get
            {
                if (iStudioConfig_UsersDAL == null)
                    iStudioConfig_UsersDAL = new StudioConfig_UsersDAL();
                return iStudioConfig_UsersDAL;
            }
            set
            {
                iStudioConfig_UsersDAL = value;
            }
        }
        #endregion
        #region 28 数据接口 IStudioConfig_UserServersDAL
        IStudioConfig_UserServersDAL iStudioConfig_UserServersDAL;
        public IStudioConfig_UserServersDAL IStudioConfig_UserServersDAL
        {
            get
            {
                if (iStudioConfig_UserServersDAL == null)
                    iStudioConfig_UserServersDAL = new StudioConfig_UserServersDAL();
                return iStudioConfig_UserServersDAL;
            }
            set
            {
                iStudioConfig_UserServersDAL = value;
            }
        }
        #endregion
        #region 29 数据接口 ISUBPROCDAL
        ISUBPROCDAL iSUBPROCDAL;
        public ISUBPROCDAL ISUBPROCDAL
        {
            get
            {
                if (iSUBPROCDAL == null)
                    iSUBPROCDAL = new SUBPROCDAL();
                return iSUBPROCDAL;
            }
            set
            {
                iSUBPROCDAL = value;
            }
        }
        #endregion
        #region 30 数据接口 IT_BPM_AWOKE_SETDAL
        IT_BPM_AWOKE_SETDAL iT_BPM_AWOKE_SETDAL;
        public IT_BPM_AWOKE_SETDAL IT_BPM_AWOKE_SETDAL
        {
            get
            {
                if (iT_BPM_AWOKE_SETDAL == null)
                    iT_BPM_AWOKE_SETDAL = new T_BPM_AWOKE_SETDAL();
                return iT_BPM_AWOKE_SETDAL;
            }
            set
            {
                iT_BPM_AWOKE_SETDAL = value;
            }
        }
        #endregion
        #region 31 数据接口 IT_BPM_PRC_APPROVALDAL
        IT_BPM_PRC_APPROVALDAL iT_BPM_PRC_APPROVALDAL;
        public IT_BPM_PRC_APPROVALDAL IT_BPM_PRC_APPROVALDAL
        {
            get
            {
                if (iT_BPM_PRC_APPROVALDAL == null)
                    iT_BPM_PRC_APPROVALDAL = new T_BPM_PRC_APPROVALDAL();
                return iT_BPM_PRC_APPROVALDAL;
            }
            set
            {
                iT_BPM_PRC_APPROVALDAL = value;
            }
        }
        #endregion
        #region 32 数据接口 IT_BPM_PRC_RGTDAL
        IT_BPM_PRC_RGTDAL iT_BPM_PRC_RGTDAL;
        public IT_BPM_PRC_RGTDAL IT_BPM_PRC_RGTDAL
        {
            get
            {
                if (iT_BPM_PRC_RGTDAL == null)
                    iT_BPM_PRC_RGTDAL = new T_BPM_PRC_RGTDAL();
                return iT_BPM_PRC_RGTDAL;
            }
            set
            {
                iT_BPM_PRC_RGTDAL = value;
            }
        }
        #endregion
        #region 33 数据接口 IT_BPM_PRCCLASS_LINKDAL
        IT_BPM_PRCCLASS_LINKDAL iT_BPM_PRCCLASS_LINKDAL;
        public IT_BPM_PRCCLASS_LINKDAL IT_BPM_PRCCLASS_LINKDAL
        {
            get
            {
                if (iT_BPM_PRCCLASS_LINKDAL == null)
                    iT_BPM_PRCCLASS_LINKDAL = new T_BPM_PRCCLASS_LINKDAL();
                return iT_BPM_PRCCLASS_LINKDAL;
            }
            set
            {
                iT_BPM_PRCCLASS_LINKDAL = value;
            }
        }
        #endregion
        #region 34 数据接口 IT_BPM_PROCESSCLASSDAL
        IT_BPM_PROCESSCLASSDAL iT_BPM_PROCESSCLASSDAL;
        public IT_BPM_PROCESSCLASSDAL IT_BPM_PROCESSCLASSDAL
        {
            get
            {
                if (iT_BPM_PROCESSCLASSDAL == null)
                    iT_BPM_PROCESSCLASSDAL = new T_BPM_PROCESSCLASSDAL();
                return iT_BPM_PROCESSCLASSDAL;
            }
            set
            {
                iT_BPM_PROCESSCLASSDAL = value;
            }
        }
        #endregion
        #region 35 数据接口 IT_BPM_PROCESSCLASS_C_USERDAL
        IT_BPM_PROCESSCLASS_C_USERDAL iT_BPM_PROCESSCLASS_C_USERDAL;
        public IT_BPM_PROCESSCLASS_C_USERDAL IT_BPM_PROCESSCLASS_C_USERDAL
        {
            get
            {
                if (iT_BPM_PROCESSCLASS_C_USERDAL == null)
                    iT_BPM_PROCESSCLASS_C_USERDAL = new T_BPM_PROCESSCLASS_C_USERDAL();
                return iT_BPM_PROCESSCLASS_C_USERDAL;
            }
            set
            {
                iT_BPM_PROCESSCLASS_C_USERDAL = value;
            }
        }
        #endregion
        #region 36 数据接口 IT_BPM_PROCESSCLASS_RIGHT_LINKDAL
        IT_BPM_PROCESSCLASS_RIGHT_LINKDAL iT_BPM_PROCESSCLASS_RIGHT_LINKDAL;
        public IT_BPM_PROCESSCLASS_RIGHT_LINKDAL IT_BPM_PROCESSCLASS_RIGHT_LINKDAL
        {
            get
            {
                if (iT_BPM_PROCESSCLASS_RIGHT_LINKDAL == null)
                    iT_BPM_PROCESSCLASS_RIGHT_LINKDAL = new T_BPM_PROCESSCLASS_RIGHT_LINKDAL();
                return iT_BPM_PROCESSCLASS_RIGHT_LINKDAL;
            }
            set
            {
                iT_BPM_PROCESSCLASS_RIGHT_LINKDAL = value;
            }
        }
        #endregion
        #region 37 数据接口 IT_BPM_READ_KNOWDAL
        IT_BPM_READ_KNOWDAL iT_BPM_READ_KNOWDAL;
        public IT_BPM_READ_KNOWDAL IT_BPM_READ_KNOWDAL
        {
            get
            {
                if (iT_BPM_READ_KNOWDAL == null)
                    iT_BPM_READ_KNOWDAL = new T_BPM_READ_KNOWDAL();
                return iT_BPM_READ_KNOWDAL;
            }
            set
            {
                iT_BPM_READ_KNOWDAL = value;
            }
        }
        #endregion
        #region 38 数据接口 IT_BPM_SYSTEM_SETDAL
        IT_BPM_SYSTEM_SETDAL iT_BPM_SYSTEM_SETDAL;
        public IT_BPM_SYSTEM_SETDAL IT_BPM_SYSTEM_SETDAL
        {
            get
            {
                if (iT_BPM_SYSTEM_SETDAL == null)
                    iT_BPM_SYSTEM_SETDAL = new T_BPM_SYSTEM_SETDAL();
                return iT_BPM_SYSTEM_SETDAL;
            }
            set
            {
                iT_BPM_SYSTEM_SETDAL = value;
            }
        }
        #endregion
        #region 39 数据接口 IT_BPM_TASK_AUTOASSIGNEDDAL
        IT_BPM_TASK_AUTOASSIGNEDDAL iT_BPM_TASK_AUTOASSIGNEDDAL;
        public IT_BPM_TASK_AUTOASSIGNEDDAL IT_BPM_TASK_AUTOASSIGNEDDAL
        {
            get
            {
                if (iT_BPM_TASK_AUTOASSIGNEDDAL == null)
                    iT_BPM_TASK_AUTOASSIGNEDDAL = new T_BPM_TASK_AUTOASSIGNEDDAL();
                return iT_BPM_TASK_AUTOASSIGNEDDAL;
            }
            set
            {
                iT_BPM_TASK_AUTOASSIGNEDDAL = value;
            }
        }
        #endregion
        #region 40 数据接口 ITASKDAL
        ITASKDAL iTASKDAL;
        public ITASKDAL ITASKDAL
        {
            get
            {
                if (iTASKDAL == null)
                    iTASKDAL = new TASKDAL();
                return iTASKDAL;
            }
            set
            {
                iTASKDAL = value;
            }
        }
        #endregion
        #region 41 数据接口 ITASKQUEUEDAL
        ITASKQUEUEDAL iTASKQUEUEDAL;
        public ITASKQUEUEDAL ITASKQUEUEDAL
        {
            get
            {
                if (iTASKQUEUEDAL == null)
                    iTASKQUEUEDAL = new TASKQUEUEDAL();
                return iTASKQUEUEDAL;
            }
            set
            {
                iTASKQUEUEDAL = value;
            }
        }
        #endregion
        #region 42 数据接口 ITASKS_ARCHIVEDAL
        ITASKS_ARCHIVEDAL iTASKS_ARCHIVEDAL;
        public ITASKS_ARCHIVEDAL ITASKS_ARCHIVEDAL
        {
            get
            {
                if (iTASKS_ARCHIVEDAL == null)
                    iTASKS_ARCHIVEDAL = new TASKS_ARCHIVEDAL();
                return iTASKS_ARCHIVEDAL;
            }
            set
            {
                iTASKS_ARCHIVEDAL = value;
            }
        }
        #endregion
        #region 43 数据接口 ITASKS_BAKDAL
        ITASKS_BAKDAL iTASKS_BAKDAL;
        public ITASKS_BAKDAL ITASKS_BAKDAL
        {
            get
            {
                if (iTASKS_BAKDAL == null)
                    iTASKS_BAKDAL = new TASKS_BAKDAL();
                return iTASKS_BAKDAL;
            }
            set
            {
                iTASKS_BAKDAL = value;
            }
        }
        #endregion
        #region 44 数据接口 ITRUSTEDUSERDAL
        ITRUSTEDUSERDAL iTRUSTEDUSERDAL;
        public ITRUSTEDUSERDAL ITRUSTEDUSERDAL
        {
            get
            {
                if (iTRUSTEDUSERDAL == null)
                    iTRUSTEDUSERDAL = new TRUSTEDUSERDAL();
                return iTRUSTEDUSERDAL;
            }
            set
            {
                iTRUSTEDUSERDAL = value;
            }
        }
        #endregion
        #region 45 数据接口 IULTIMUSREPALERTDAL
        IULTIMUSREPALERTDAL iULTIMUSREPALERTDAL;
        public IULTIMUSREPALERTDAL IULTIMUSREPALERTDAL
        {
            get
            {
                if (iULTIMUSREPALERTDAL == null)
                    iULTIMUSREPALERTDAL = new ULTIMUSREPALERTDAL();
                return iULTIMUSREPALERTDAL;
            }
            set
            {
                iULTIMUSREPALERTDAL = value;
            }
        }
        #endregion
        #region 46 数据接口 IULTIMUSREPORTDAL
        IULTIMUSREPORTDAL iULTIMUSREPORTDAL;
        public IULTIMUSREPORTDAL IULTIMUSREPORTDAL
        {
            get
            {
                if (iULTIMUSREPORTDAL == null)
                    iULTIMUSREPORTDAL = new ULTIMUSREPORTDAL();
                return iULTIMUSREPORTDAL;
            }
            set
            {
                iULTIMUSREPORTDAL = value;
            }
        }
        #endregion
        #region 47 数据接口 IULTVIEWDAL
        IULTVIEWDAL iULTVIEWDAL;
        public IULTVIEWDAL IULTVIEWDAL
        {
            get
            {
                if (iULTVIEWDAL == null)
                    iULTVIEWDAL = new ULTVIEWDAL();
                return iULTVIEWDAL;
            }
            set
            {
                iULTVIEWDAL = value;
            }
        }
        #endregion
        #region 48 数据接口 IUSERSERVERPREFERENCEDAL
        IUSERSERVERPREFERENCEDAL iUSERSERVERPREFERENCEDAL;
        public IUSERSERVERPREFERENCEDAL IUSERSERVERPREFERENCEDAL
        {
            get
            {
                if (iUSERSERVERPREFERENCEDAL == null)
                    iUSERSERVERPREFERENCEDAL = new USERSERVERPREFERENCEDAL();
                return iUSERSERVERPREFERENCEDAL;
            }
            set
            {
                iUSERSERVERPREFERENCEDAL = value;
            }
        }
        #endregion
        #region 49 数据接口 IVIEWFOLDERDAL
        IVIEWFOLDERDAL iVIEWFOLDERDAL;
        public IVIEWFOLDERDAL IVIEWFOLDERDAL
        {
            get
            {
                if (iVIEWFOLDERDAL == null)
                    iVIEWFOLDERDAL = new VIEWFOLDERDAL();
                return iVIEWFOLDERDAL;
            }
            set
            {
                iVIEWFOLDERDAL = value;
            }
        }
        #endregion
    }
}
