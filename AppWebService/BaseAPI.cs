using Common;
using Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWebService
{
    /// <summary>
    /// web基础接口
    /// </summary>
    public static class BaseAPI
    {
        public static string BASE_URL = System.Configuration.ConfigurationManager.AppSettings["BaseURL"].ToString();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="loginPass"></param>
        /// <returns></returns>
        public static ReturnSimpleResult2<AppRegsiterResult> AppLoginV2(string loginName,string loginPass)
        {
            string result = "";
            string method = "AppLoginV2";
            string parm = "loginName="+loginName+"&loginPass="+ loginPass + "";
            result = HttpHelper.HttpPost(BASE_URL + method, parm);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            ReturnSimpleResult2<AppRegsiterResult> ret = new ReturnSimpleResult2<AppRegsiterResult>();
            if (jo["ResultCode"].ToString() == "200")
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
                ret.t = new AppRegsiterResult();
                ret.t.CurrentOrganizeEntity = new OrganizeEntity();
                ret.t.CurrentUser = new UserEntity();

                ret.t.CurrentUser.F_Id = jo["t"]["CurrentUser"]["F_Id"].ToString();
                ret.t.CurrentUser.F_Account = jo["t"]["CurrentUser"]["F_Account"].ToString();
                ret.t.CurrentUser.F_RealName = jo["t"]["CurrentUser"]["F_RealName"].ToString();
                ret.t.CurrentUser.F_NickName = jo["t"]["CurrentUser"]["F_NickName"].ToString();
                ret.t.CurrentUser.F_HeadIcon = jo["t"]["CurrentUser"]["F_HeadIcon"].ToString();
                //ret.t.CurrentUser.F_Gender = jo["t"]["CurrentUser"]["F_Gender"].ToString();
                //ret.t.CurrentUser.F_Birthday = jo["t"]["CurrentUser"]["F_Birthday"].ToString();
                ret.t.CurrentUser.F_MobilePhone = jo["t"]["CurrentUser"]["F_MobilePhone"].ToString();
                ret.t.CurrentUser.F_Email = jo["t"]["CurrentUser"]["F_Email"].ToString();
                ret.t.CurrentUser.F_WeChat = jo["t"]["CurrentUser"]["F_WeChat"].ToString();
                ret.t.CurrentUser.F_ManagerId = jo["t"]["CurrentUser"]["F_ManagerId"].ToString();
                //ret.t.CurrentUser.F_SecurityLevel = jo["t"]["CurrentUser"]["F_SecurityLevel"].ToString();
                ret.t.CurrentUser.F_Signature = jo["t"]["CurrentUser"]["F_Signature"].ToString();
                ret.t.CurrentUser.F_OrganizeId = jo["t"]["CurrentUser"]["F_OrganizeId"].ToString();
                ret.t.CurrentUser.F_DepartmentId = jo["t"]["CurrentUser"]["F_DepartmentId"].ToString();
                ret.t.CurrentUser.F_RoleId = jo["t"]["CurrentUser"]["F_RoleId"].ToString();
                ret.t.CurrentUser.F_DutyId = jo["t"]["CurrentUser"]["F_DutyId"].ToString();
                //ret.t.CurrentUser.F_IsAdministrator = jo["t"]["CurrentUser"]["F_IsAdministrator"].ToString();
                //ret.t.CurrentUser.F_SortCode = jo["t"]["CurrentUser"]["F_SortCode"].ToString();
                //ret.t.CurrentUser.F_DeleteMark = jo["t"]["CurrentUser"]["F_DeleteMark"].ToString();
                //ret.t.CurrentUser.F_EnabledMark = jo["t"]["CurrentUser"]["F_EnabledMark"].ToString();
                ret.t.CurrentUser.F_Description = jo["t"]["CurrentUser"]["F_Description"].ToString();
                //ret.t.CurrentUser.F_CreatorTime = jo["t"]["CurrentUser"]["F_CreatorTime"].ToString();
                ret.t.CurrentUser.F_CreatorUserId = jo["t"]["CurrentUser"]["F_CreatorUserId"].ToString();
                //ret.t.CurrentUser.F_LastModifyTime = jo["t"]["CurrentUser"]["F_LastModifyTime"].ToString();
                ret.t.CurrentUser.F_LastModifyUserId = jo["t"]["CurrentUser"]["F_LastModifyUserId"].ToString();
                //ret.t.CurrentUser.F_DeleteTime = jo["t"]["CurrentUser"]["F_DeleteTime"].ToString();
                ret.t.CurrentUser.F_DeleteUserId = jo["t"]["CurrentUser"]["F_DeleteUserId"].ToString();
                ret.t.CurrentUser.OrgNo = int.Parse( jo["t"]["CurrentUser"]["OrgNo"].ToString());

                ret.t.CurrentOrganizeEntity.F_Id = jo["t"]["CurrentOrganizeEntity"]["F_Id"].ToString();
                ret.t.CurrentOrganizeEntity.F_ParentId = jo["t"]["CurrentOrganizeEntity"]["F_ParentId"].ToString();
                ret.t.CurrentOrganizeEntity.F_Layers =int.Parse( jo["t"]["CurrentOrganizeEntity"]["F_Layers"].ToString());
                ret.t.CurrentOrganizeEntity.F_EnCode = jo["t"]["CurrentOrganizeEntity"]["F_EnCode"].ToString();
                ret.t.CurrentOrganizeEntity.F_FullName = jo["t"]["CurrentOrganizeEntity"]["F_FullName"].ToString();
                ret.t.CurrentOrganizeEntity.F_ShortName = jo["t"]["CurrentOrganizeEntity"]["F_ShortName"].ToString();
                ret.t.CurrentOrganizeEntity.F_CategoryId = jo["t"]["CurrentOrganizeEntity"]["F_CategoryId"].ToString();
                ret.t.CurrentOrganizeEntity.F_ManagerId = jo["t"]["CurrentOrganizeEntity"]["F_ManagerId"].ToString();
                ret.t.CurrentOrganizeEntity.F_TelePhone = jo["t"]["CurrentOrganizeEntity"]["F_TelePhone"].ToString();
                ret.t.CurrentOrganizeEntity.F_MobilePhone = jo["t"]["CurrentOrganizeEntity"]["F_MobilePhone"].ToString();
                ret.t.CurrentOrganizeEntity.F_WeChat = jo["t"]["CurrentOrganizeEntity"]["F_WeChat"].ToString();
                ret.t.CurrentOrganizeEntity.F_Fax = jo["t"]["CurrentOrganizeEntity"]["F_Fax"].ToString();
                ret.t.CurrentOrganizeEntity.F_Email = jo["t"]["CurrentOrganizeEntity"]["F_Email"].ToString();
                ret.t.CurrentOrganizeEntity.F_AreaId = jo["t"]["CurrentOrganizeEntity"]["F_AreaId"].ToString();
                ret.t.CurrentOrganizeEntity.F_Address = jo["t"]["CurrentOrganizeEntity"]["F_Address"].ToString();
                //ret.t.CurrentOrganizeEntity.F_AllowEdit = jo["t"]["CurrentOrganizeEntity"]["F_AllowEdit"].ToString();
                //ret.t.CurrentOrganizeEntity.F_AllowDelete = jo["t"]["CurrentOrganizeEntity"]["F_AllowDelete"].ToString();
                //ret.t.CurrentOrganizeEntity.F_SortCode = jo["t"]["CurrentOrganizeEntity"]["F_SortCode"].ToString();
                //ret.t.CurrentOrganizeEntity.F_DeleteMark = jo["t"]["CurrentOrganizeEntity"]["F_DeleteMark"].ToString();
                //ret.t.CurrentOrganizeEntity.F_EnabledMark = jo["t"]["CurrentOrganizeEntity"]["F_EnabledMark"].ToString();
                ret.t.CurrentOrganizeEntity.F_Description = jo["t"]["CurrentOrganizeEntity"]["F_Description"].ToString();
                //ret.t.CurrentOrganizeEntity.F_CreatorTime = DateTime.Parse( jo["t"]["CurrentOrganizeEntity"]["F_CreatorTime"].ToString());
                ret.t.CurrentOrganizeEntity.F_CreatorUserId = jo["t"]["CurrentOrganizeEntity"]["F_CreatorUserId"].ToString();
                //ret.t.CurrentOrganizeEntity.F_LastModifyTime = DateTime.Parse( jo["t"]["CurrentOrganizeEntity"]["F_LastModifyTime"].ToString());
                ret.t.CurrentOrganizeEntity.F_LastModifyUserId = jo["t"]["CurrentOrganizeEntity"]["F_LastModifyUserId"].ToString();
                //ret.t.CurrentOrganizeEntity.F_DeleteTime = jo["t"]["CurrentOrganizeEntity"]["F_DeleteTime"].ToString();
                ret.t.CurrentOrganizeEntity.F_DeleteUserId = jo["t"]["CurrentOrganizeEntity"]["F_DeleteUserId"].ToString();
                ret.t.CurrentOrganizeEntity.MemberNum = jo["t"]["CurrentOrganizeEntity"]["MemberNum"].ToString();
                ret.t.CurrentOrganizeEntity.SeatNum =int.Parse( jo["t"]["CurrentOrganizeEntity"]["SeatNum"].ToString());
                //ret.t.CurrentOrganizeEntity.MasterImage = jo["t"]["CurrentOrganizeEntity"]["MasterImage"].ToString();
                ret.t.CurrentOrganizeEntity.OrgNo = int.Parse( jo["t"]["CurrentOrganizeEntity"]["OrgNo"].ToString());

            }
            else
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
            }
            return ret;
        }

        /// <summary>
        /// 门店注册
        /// </summary>
        /// <param name="orgFullName"></param>
        /// <param name="F_Description"></param>
        /// <param name="MemberNum"></param>
        /// <param name="SeatNum"></param>
        /// <param name="loginName"></param>
        /// <param name="loginPass"></param>
        /// <param name="F_RealName"></param>
        /// <returns></returns>
        public static ReturnSimpleResult2<AppRegsiterResult> AppRegV2(string orgFullName,
           string F_Description, string MemberNum, int SeatNum,
            string loginName, string loginPass, string F_RealName)
        {
            ReturnSimpleResult2<AppRegsiterResult> ret = new ReturnSimpleResult2<AppRegsiterResult>();
            string result = "";
            string method = "AppRegV2";
            string parm = "orgFullName=" + orgFullName + "&F_Description=" + F_Description + "&MemberNum=" + MemberNum + "&SeatNum=" + SeatNum + "&loginName=" + loginName + "&loginPass="+ loginPass + "&F_RealName="+ F_RealName + "";
            result = HttpHelper.HttpPost(BASE_URL + method, parm);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            ret.ResultCode = jo["ResultCode"].ToString();
            ret.Msg = jo["Msg"].ToString();
            return ret;
        }

        /// <summary>
        /// 订单查询
        /// </summary>
        /// <param name="OrderNo"></param>
        /// <returns></returns>
        public static ReturnPageResult<ApiOrderAndInfosModel> GetOrderInfo(string OrderNo)
        {
            ReturnPageResult<ApiOrderAndInfosModel> ret = new ReturnPageResult<ApiOrderAndInfosModel>();
            string result = "";
            string method = "GetOrderInfo";
            string parm = "_OrderNo="+ OrderNo + "";
            result = HttpHelper.HttpPost(BASE_URL + method, parm);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            ret.ResultCode = jo["ResultCode"].ToString();
            if (jo["ResultCode"].ToString() == "200")
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
                ret.Data1 = new ApiOrderAndInfosModel();
                ret.Data1.order = new List<T_ORDEREntity>();
                ret.Data1.order_info = new List<T_ORDER_INFOEntity>();
                JArray orderList = JArray.Parse(jo["Data1"]["order"].ToString());
                JArray infoList = JArray.Parse(jo["Data1"]["order_info"].ToString());
                foreach (var item in orderList)
                {
                    T_ORDEREntity o = new T_ORDEREntity();
                    o.OID = int.Parse(item["OID"].ToString());
                    o.OrderNo = item["OrderNo"].ToString();
                    o.CreateTime = DateTime.Parse( item["CreateTime"].ToString());
                    o.Seat = item["Seat"].ToString();
                    o.PeopleNum = int.Parse( item["PeopleNum"].ToString());
                    o.MemberName = item["MemberName"].ToString();
                    o.Dec = item["Dec"].ToString();
                    o.OrderState = int.Parse( item["OrderState"].ToString());
                    o.ModifiedOn = DateTime.Parse( item["ModifiedOn"].ToString());
                    o.OrgID = int.Parse( item["OrgID"].ToString());
                    ret.Data1.order.Add(o);
                }

                foreach (var item in infoList)
                {
                    T_ORDER_INFOEntity info = new T_ORDER_INFOEntity();
                    info.OID = int.Parse(item["OID"].ToString());
                    info.OrderNo = item["OrderNo"].ToString();
                    info.ProductId = item["ProductId"].ToString();
                    info.ProductCname = item["ProductCname"].ToString();
                    info.PNum = double.Parse(item["PNum"].ToString());
                    info.Price1 = decimal.Parse(item["Price1"].ToString());
                    info.Price2 = decimal.Parse(item["Price2"].ToString());
                    info.MemberName = item["MemberName"].ToString();
                    info.CreateOn = DateTime.Parse(item["CreateOn"].ToString());
                    info.ModifiedOn = DateTime.Parse( item["ModifiedOn"].ToString());
                    ret.Data1.order_info.Add(info);
                }
            }
            else
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
            }
            return ret;
        }

        /// <summary>
        /// 获取订单号（开单用）
        /// </summary>
        /// <param name="_orgid"></param>
        /// <returns></returns>
        public static ReturnPageResult<T_ORDEREntity> GetOrderNo(string _orgid)
        {
            ReturnPageResult<T_ORDEREntity> ret = new ReturnPageResult<T_ORDEREntity>();
            string result = "";
            string method = "GetOrderNo";
            string parm = "_orgid=" + _orgid + "";
            result = HttpHelper.HttpPost(BASE_URL + method, parm);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            ret.ResultCode = jo["ResultCode"].ToString();
            if (ret.ResultCode == "200")
            {
                T_ORDEREntity o = new T_ORDEREntity();
                o.OrderNo = jo["strNo"].ToString();
                ret.Data1 = new T_ORDEREntity();
                ret.Data1.OrderNo = o.OrderNo;
            }
            else
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
            }
            return ret;
        }

        /// <summary>
        /// 获取简单组织架构列表
        /// </summary>
        /// <param name="_pageIndex"></param>
        /// <param name="_pageSize"></param>
        /// <param name="_cname"></param>
        /// <returns></returns>
        public static ReturnPageResult<SimpleOrgEntity> GetOrgSimpleList(string _pageIndex, string _pageSize, string _cname)
        {
            ReturnPageResult<SimpleOrgEntity> ret = new ReturnPageResult<SimpleOrgEntity>();
            string result = "";
            string method = "GetOrgSimpleList";
            string parm = "_pageIndex="+ _pageIndex + "&_pageSize="+ _pageSize + "&_cname="+ _cname + "";
            result = HttpHelper.HttpPost(BASE_URL + method, parm);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            ret.ResultCode = jo["ResultCode"].ToString();
            if (ret.ResultCode == "200")
            {
                ret.Page = new PageObject<SimpleOrgEntity>();
                ret.Page.PageCount = int.Parse(jo["Page"]["PageCount"].ToString());
                ret.Page.PageIndex = int.Parse(jo["Page"]["PageIndex"].ToString());
                ret.Page.PageSize = int.Parse(jo["Page"]["PageSize"].ToString());
                ret.Page.RecordCount = int.Parse(jo["Page"]["RecordCount"].ToString());
                ret.Page.Data = new List<SimpleOrgEntity>();
                JArray list = JArray.Parse(jo["Page"]["Data"].ToString());
                foreach (var item in list)
                {
                    SimpleOrgEntity o = new SimpleOrgEntity();
                    o.OID = item["OID"].ToString();
                    o.LongName = item["LongName"].ToString();

                    ret.Page.Data.Add(o);
                }
            }
            else
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
            }
            return ret;
        }

        /// <summary>
        /// 获取商品类别列表
        /// </summary>
        /// <param name="_orgid"></param>
        /// <returns></returns>
        public static ReturnPageResult<SimpleProductCateory> GetProductCategoryList(string _orgid)
        {
            ReturnPageResult<SimpleProductCateory> ret = new ReturnPageResult<SimpleProductCateory>();
            string result = "";
            string method = "GetProductCateoryList";
            string parm = "_orgid="+ _orgid + "";
            result = HttpHelper.HttpPost(BASE_URL + method, parm);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            ret.ResultCode = jo["ResultCode"].ToString();
            if (ret.ResultCode == "200")
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
                ret.Page = new PageObject<SimpleProductCateory>();
                ret.Page.PageCount = int.Parse(jo["Page"]["PageCount"].ToString());
                ret.Page.PageIndex = int.Parse(jo["Page"]["PageIndex"].ToString());
                ret.Page.PageSize = int.Parse(jo["Page"]["PageSize"].ToString());
                ret.Page.RecordCount = int.Parse(jo["Page"]["RecordCount"].ToString());
                ret.Page.Data = new List<SimpleProductCateory>();
                JArray list = JArray.Parse(jo["Page"]["Data"].ToString());
                foreach (var item in list)
                {
                    SimpleProductCateory c = new SimpleProductCateory();
                    c.OID = item["OID"].ToString();
                    c.CName = item["CName"].ToString();
                    ret.Page.Data.Add(c);
                }
            }
            else
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
            }
            return ret;
        }

        /// <summary>
        /// 根据类别获取商品列表
        /// </summary>
        /// <param name="_pageIndex"></param>
        /// <param name="_pageSize"></param>
        /// <param name="_oid"></param>
        /// <param name="_orgid"></param>
        /// <returns></returns>
        public static ReturnPageResult<SimpleProduct> GetProductListByPCategory(string _pageIndex, string _pageSize, string _oid, string _orgid)
        {
            ReturnPageResult<SimpleProduct> ret = new ReturnPageResult<SimpleProduct>();
            string result = "";
            string method = "GetProductListByPCategory";
            string parm = "_pageIndex="+_pageIndex+"&_pageSize="+_pageSize+"&_oid="+_oid+"&_orgid="+_orgid+"";
            result = HttpHelper.HttpPost(BASE_URL + method, parm);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            ret.ResultCode = jo["ResultCode"].ToString();
            if (ret.ResultCode == "200")
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
                ret.Page = new PageObject<SimpleProduct>();
                ret.Page.PageCount = int.Parse(jo["Page"]["PageCount"].ToString());
                ret.Page.PageIndex = int.Parse(jo["Page"]["PageIndex"].ToString());
                ret.Page.PageSize = int.Parse(jo["Page"]["PageSize"].ToString());
                ret.Page.RecordCount = int.Parse(jo["Page"]["RecordCount"].ToString());
                ret.Page.Data = new List<SimpleProduct>();
                JArray list = JArray.Parse(jo["Page"]["Data"].ToString());
                foreach (var item in list)
                {
                    SimpleProduct c = new SimpleProduct();
                    c.OID = item["OID"].ToString();
                    c.CName = item["CName"].ToString();
                    c.Price1 = item["Price1"].ToString();
                    c.Price2 = item["Price2"].ToString();
                    c.PIngredients = item["PIngredients"].ToString();
                    c.PContent = item["PContent"].ToString();
                    c.PPractice = item["PPractice"].ToString();
                    c.ImgName = item["ImgName"].ToString();
                    ret.Page.Data.Add(c);
                }
            }
            else
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
            }
            return ret;
        }

        /// <summary>
        /// 获取台位和员工列表
        /// </summary>
        /// <param name="_orgid"></param>
        /// <returns></returns>
        public static ReturnPageResult<ApiSeatsAndEmpsModel> GetSeatsAndMembers(string _orgid)
        {
            ReturnPageResult<ApiSeatsAndEmpsModel> ret = new ReturnPageResult<ApiSeatsAndEmpsModel>();
            string result = "";
            string method = "GetSeatANDMember";
            string parm = "_orgid="+ _orgid + "";
            result = HttpHelper.HttpPost(BASE_URL + method, parm);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            ret.ResultCode = jo["ResultCode"].ToString();
            if (ret.ResultCode == "200")
            {
                ret.Data1 = new ApiSeatsAndEmpsModel();
                ret.Data1.Members = new List<T_MEMBERSEntity>();
                ret.Data1.Seats = new List<T_SEATEntity>();
                JArray Seats = JArray.Parse(jo["Data1"]["Seats"].ToString());
                JArray Members = JArray.Parse(jo["Data1"]["Members"].ToString());

                foreach (var item in Seats)
                {
                    T_SEATEntity s = new T_SEATEntity();
                    s.OID = int.Parse(item["OID"].ToString());
                    s.ParentID = int.Parse(item["ParentID"].ToString());
                    s.SeatNo = item["SeatNo"].ToString();
                    s.SaatCategory = item["SaatCategory"].ToString();
                    s.PersonNum = int.Parse( item["PersonNum"].ToString());
                    s.OrgID = int.Parse(item["OrgID"].ToString());
                    s.Desc = item["Desc"].ToString();
                    s.Status = item["Status"].ToString();
                    ret.Data1.Seats.Add(s);
                }

                foreach (var item in Members)
                {
                    T_MEMBERSEntity m = new T_MEMBERSEntity();
                    m.OID = int.Parse(item["OID"].ToString());
                    m.Cname = item["Cname"].ToString();
                    m.Gender = item["Gender"].ToString();
                    m.Introduction = item["Introduction"].ToString();
                    m.OrgID = int.Parse( item["OrgID"].ToString());
                    //m.DeletionStateCode = item["DeletionStateCode"].ToString();
                    //m.Enabled = item["Enabled"].ToString();
                    //m.SortCode = item["SortCode"].ToString();
                    m.Description = item["Description"].ToString();
                    //m.CreateOn = item["CreateOn"].ToString();
                    //m.CreateUserId = item["CreateUserId"].ToString();
                    m.CreateBy = item["CreateBy"].ToString();
                    //m.ModifiedOn = item["ModifiedOn"].ToString();
                    //m.ModifiedUserId = item["ModifiedUserId"].ToString();
                    m.ModifiedBy = item["ModifiedBy"].ToString();
                    ret.Data1.Members.Add(m);
                }
            }
            else
            {
                ret.ResultCode = jo["ResultCode"].ToString();
                ret.Msg = jo["Msg"].ToString();
            }
            return ret;
        }

    }
}
