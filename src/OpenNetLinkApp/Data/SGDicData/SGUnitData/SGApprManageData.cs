﻿using System;
using System.Collections.Generic;
using System.Text;
using HsNetWorkSGData;
using HsNetWorkSG;
using OpenNetLinkApp.Services;

namespace OpenNetLinkApp.Data.SGDicData.SGUnitData
{
    public enum eApprManageFail
    {
        eNone = 0
    }
    public class SGApprManageData : SGData
    {
        XmlConfService xmlConf;
        public SGApprManageData()
        {
            xmlConf = new XmlConfService();
        }
        
        ~SGApprManageData()
        {

        }
        public void Copy(HsNetWork hs, SGData data)
        {
            SetSessionKey(hs.GetSeedKey());
            m_DicTagData = new Dictionary<string, string>(data.m_DicTagData);
            m_DicRecordData = new List<Dictionary<int, string>>(data.m_DicRecordData);
        }
        public int GetSearchResultCount()
        {
            string strData = GetTagData("APPROVECOUNT");
            int count = 0;
            if (!strData.Equals(""))
                count = Convert.ToInt32(strData);
            return count;
        }
        public static string FailMessage(eApprManageFail eType)
        {
            string strFailMsg = "";
            XmlConfService xmlConf = new XmlConfService();
            switch (eType)
            {
                case eApprManageFail.eNone:
                    break;
            }

            return strFailMsg;
        }
        public List<Dictionary<int, string>> GetSearchData()
        {
            List<Dictionary<int, string>> listDicdata = GetRecordData("APPROVERECORD");
            return listDicdata;
        }

        /**
		 * @breif 결재 정보를 반환한다.
		 * @return 결재 정보(선결,후결)
		 */
        public string GetApprKind(Dictionary<int, string> dic)
        {
            string strApprKind = "";
            if (dic.TryGetValue(8, out strApprKind) != true)
                return strApprKind;
            strApprKind = dic[8];

            int nIndex = 0;
            if (!strApprKind.Equals(""))
                nIndex = Convert.ToInt32(strApprKind);

            switch (nIndex)
            {
                case 0:
                    strApprKind = xmlConf.GetTitle("T_COMMON_APPROVE_BEFORE");        // 선결
                    break;
                case 1:
                    strApprKind = xmlConf.GetTitle("T_COMMON_APPROVE_AFTER");        // 후결
                    break;
                default:
                    break;
            }

            return strApprKind;
        }
        /**
		 * @breif 개인정보 검출 상태 정보를 반환한다.
		 * @return 개인정보 검출 상태 (미사용,포함,미포함,검출불가)
		 */
        public string GetDlp(Dictionary<int, string> dic)
        {
            string strDlp = "";
            if (dic.TryGetValue(2, out strDlp) != true)
                return strDlp;
            strDlp = dic[2];

            int nIndex = 0;
            if (!strDlp.Equals(""))
                nIndex = Convert.ToInt32(strDlp);

            switch (nIndex)
            {
                case 0:
                    strDlp = xmlConf.GetTitle("T_COMMON_DLP_UNUSE");            // 미사용
                    break;
                case 1:
                    strDlp = xmlConf.GetTitle("T_COMMON_DLP_INCLUSION");            // 포함
                    break;
                case 2:
                    strDlp = xmlConf.GetTitle("T_COMMON_DLP_NOTINCLUSION");            // 미포함
                    break;
                case 3:
                    strDlp = xmlConf.GetTitle("T_COMMON_DLP_UNKNOWN");            // 검출불가
                    break;
                default:
                    strDlp = "0";
                    break;
            }
            return strDlp;
        }
        /**
		 * @breif 전송구분 정보를 반환한다.
		 * @return 전송구분 정보(반출/반입)
		 */
        public string GetTransKind(Dictionary<int, string> dic)
        {
            string strTransKind = "";
            if (dic.TryGetValue(6, out strTransKind) != true)
                return strTransKind;

            strTransKind = dic[6];

            int nIndex = 0;
            if (!strTransKind.Equals(""))
                nIndex = Convert.ToInt32(strTransKind);

            switch (nIndex)
            {
                case 1:
                    strTransKind = xmlConf.GetTitle("T_COMMON_EXPORT");          // 반출
                    break;
                case 2:
                    strTransKind = xmlConf.GetTitle("T_COMMON_IMPORT");          // 반입
                    break;
                default:
                    strTransKind = "-";
                    break;
            }

            return strTransKind;
        }

        /**
		 * @breif 결재요청자 정보를 반환한다.
		 * @return 결재요청자 정보
		 */
        public string GetApproveReqUser(Dictionary<int, string> dic)
        {
            string strApproveReqUser = "";
            if (dic.TryGetValue(4, out strApproveReqUser) != true)
                return strApproveReqUser;

            strApproveReqUser = dic[4];
            return strApproveReqUser;
        }

        /**
		 * @breif TransSequence 정보를 반환한다.
		 * @return TransSequence 정보
		 */
        public string GetTransSeq(Dictionary<int, string> dic)
        {
            string strTransSeq = "";
            if (dic.TryGetValue(0, out strTransSeq) != true)
                return strTransSeq;
            strTransSeq = dic[0];
            return strTransSeq;
        }

        /**
		 * @breif ApproveSequence 정보를 반환한다.
		 * @return ApproveSequence 정보
		 */
        public string GetApproveSeq(Dictionary<int, string> dic)
        {
            string strApproveSeq = "";
            if (dic.TryGetValue(1, out strApproveSeq) != true)
                return strApproveSeq;
            strApproveSeq = dic[1];
            return strApproveSeq;
        }
        /**
		 * @breif 승인대기 상태가 요청취소로 변경 할지 여부를 판단하기 위한 값을 반환한다.
		 * @return 요청취소 판단 값. (0 : 요청취소 조건 아님, 1: 사용자가 전송취소 한 경우, 2: 이전 결재자가 반려한 경우
		 */
        public int GetRequestCancelChk(Dictionary<int, string> dic)
        {
            string strTransStatus = "";
            string strApprStatus = "";
            string strApprDataPos = "";
            if(
                (dic.TryGetValue(7, out strTransStatus)!=true)
                || (dic.TryGetValue(9, out strApprStatus) != true)
                || (dic.TryGetValue(13, out strApprDataPos) != true)
                )
            {
                return 0;
            }

            strTransStatus = dic[7];                            // 전송상태 (W:전송대기,C:전송취소,P:전송완료,F:전송실패,V:검사중)
            strApprStatus = dic[9];                             // 결재상태 (1:승인대기,2:승인,3:반려)
            strApprDataPos = dic[13];                           // 결재 데이터 위치 (C:결재테이블, H:결재 이력 테이블)

            if((strTransStatus.Equals("C") == true) && (strApprStatus.Equals("1") == true))     // 전송상태가 전송취소이면서 결재상태가 승인대기일때
                return 1;

            if (
                (strTransStatus.Equals("W") == true)
                && (strApprStatus.Equals("1") == true)
                && (strApprDataPos.Equals("H") == true)
                )                                                                               // 전송상태가 전송대기이고 결재상태가 승인대기 일때 결재 데이터 위치가 결재 이력 테이블에 존재하면
                return 2;

            return 0;
        }
        /**
		 * @breif 결재상태 정보를 반환한다.
		 * @return 결재상태 정보(요청취소,승인대기,승인,반려)
		 */
        public string GetApprStaus(Dictionary<int, string> dic)
        {
            string strTempApprStatus = "";
            if (GetRequestCancelChk(dic) != 0)
            {
                strTempApprStatus=xmlConf.GetTitle("T_COMMON_REQUESTCANCEL");       // 요청취소
                return strTempApprStatus;
            }

            string strApprStatus = "-";
            string strApprStepStatus = "";
            if ( (dic.TryGetValue(9, out strApprStatus) != true) || (dic.TryGetValue(15, out strApprStepStatus) != true) )
                return strApprStatus;

            strApprStatus = dic[9];           // 1: 승인 대기, 2: 승인, 3: 반려
            strApprStepStatus = dic[15];      // 1: 승인 가능 상태, 2 : 승인 불가능한 상태.
            strTempApprStatus = strApprStatus;

            if (
                (strApprStatus.Equals("1") == true)
                && (strApprStepStatus.Equals("2") == true)
                && (strTempApprStatus.Equals("4") != true)
                )
                return "-";
            else
            {
                int nIndex = 0;
                if (!strApprStatus.Equals(""))
                    nIndex = Convert.ToInt32(strApprStatus);

                switch(nIndex)
                {
                    case 1:
                        strApprStatus = xmlConf.GetTitle("T_COMMON_APPROVE_WAIT");              // 승인대기
                        break;
                    case 2:
                        strApprStatus = xmlConf.GetTitle("T_COMMON_APPROVE");                   // 승인
                        break;
                    case 3:
                        strApprStatus = xmlConf.GetTitle("T_COMMON_REJECTION");                   // 반려
                        break;
                    case 4:
                        strApprStatus = xmlConf.GetTitle("T_COMMON_REQUESTCANCEL");                   // 요청취소
                        break;
                    default:
                        strApprStatus = "-";
                        break;
                }
            }
            return strApprStatus;
        }

        /**
		 * @breif 파일 포워딩 사용 여부를 반환한다.
		 * @return 파일 포워딩 사용 여부 (사용, 미사용)
		 */
        public string GetUseFileForward(Dictionary<int, string> dic)
        {
            string strUseFileForward = "-";
            if (dic.TryGetValue(16, out strUseFileForward) != true)
                return strUseFileForward;

            strUseFileForward = dic[16];            // 파일 포워딩 사용 여부 ( 0 : 포워딩한 사용자가 없음, 1: 포워딩한 사용자가 있음)

            int nIndex = 0;
            if (!strUseFileForward.Equals(""))
                nIndex = Convert.ToInt32(strUseFileForward);

            switch (nIndex)
            {
                case 0:
                    strUseFileForward = xmlConf.GetTitle("T_COMMON_FORWARD_UNUSE");              // 미사용
                    break;
                case 1:
                    strUseFileForward = xmlConf.GetTitle("T_COMMON_FORWARD_USE");                   // 사용
                    break;
                default:
                    strUseFileForward = "-";
                    break;
            }
            return strUseFileForward;
        }

        /**
        * @breif 파일 수신위치 정보를 반환한다.
        * @return 파일 수신위치(보안웹하드, 업무PC/인터넷PC)
        */
        public string GetRecvPos(Dictionary<int, string> dic)
        {
            string strRecvPos = "";
            string strTransKind = "";
            if ((dic.TryGetValue(18, out strRecvPos) != true) || (dic.TryGetValue(6, out strTransKind) != true))
                return strRecvPos;

            strRecvPos = dic[18];
            strTransKind = dic[6];

            int nIndex = 0;
            if (!strRecvPos.Equals(""))
                nIndex = Convert.ToInt32(strRecvPos);

            switch (nIndex)
            {
                case 0:
                    if (strTransKind.Equals("1"))                // 반출이면
                        strRecvPos = xmlConf.GetTitle("T_RECV_INTERNETPC");     // 인터넷 PC
                    else                                        // 반입이면
                        strRecvPos = xmlConf.GetTitle("T_RECV_BUSINESSPC");     //  PC
                    break;
                case 1:
                    strRecvPos = xmlConf.GetTitle("T_SECURITY_WEBHARD");        // 보안웹하드
                    break;
                default:
                    strRecvPos = "-";
                    break;
            }
            return strRecvPos;
        }
        /**
		 * @breif 사용자가 파일 전송 시 입력한 제목을 반환한다.
		 * @return 제목
		 */
        public string GetTitle(Dictionary<int, string> dic)
        {
            string strTitle = "";
            if (dic.TryGetValue(10, out strTitle) != true)
                return strTitle;
            strTitle = dic[10];
            return strTitle;
        }
        /**
		 * @breif 전송요청일 정보를 반환한다.
		 * @return 전송요청일(type : YYYY-MM-DD hh:mm:ss)
		 */
        public string GetTransReqDay(Dictionary<int, string> dic)
        {
            string strTransReqDay = "";
            if (dic.TryGetValue(11, out strTransReqDay) != true)
                return strTransReqDay;

            strTransReqDay = dic[11];
            string strYear = strTransReqDay.Substring(0, 4);
            string strMonth = strTransReqDay.Substring(4, 2);
            string strDay = strTransReqDay.Substring(6, 2);
            string strHour = strTransReqDay.Substring(8, 2);
            string strMinute = strTransReqDay.Substring(10, 2);
            string strSecond = strTransReqDay.Substring(12, 2);

            strTransReqDay = String.Format("{0}-{1}-{2} {3}:{4}:{5}", strYear, strMonth, strDay, strHour, strMinute, strSecond);
            return strTransReqDay;
        }
        /**
		 * @breif 결재일 정보를 반환한다.
		 * @return 결재일(type : YYYY-MM-DD hh:mm:ss)
		 */
        public string GetApprDay(Dictionary<int, string> dic)
        {
            string strTransReqDay = "";
            if (dic.TryGetValue(12, out strTransReqDay) != true)
                return "-";

            strTransReqDay = dic[12];
            string strYear = strTransReqDay.Substring(0, 4);
            string strMonth = strTransReqDay.Substring(4, 2);
            string strDay = strTransReqDay.Substring(6, 2);
            string strHour = strTransReqDay.Substring(8, 2);
            string strMinute = strTransReqDay.Substring(10, 2);
            string strSecond = strTransReqDay.Substring(12, 2);

            strTransReqDay = String.Format("{0}-{1}-{2} {3}:{4}:{5}", strYear, strMonth, strDay, strHour, strMinute, strSecond);
            return strTransReqDay;
        }
    }
}
