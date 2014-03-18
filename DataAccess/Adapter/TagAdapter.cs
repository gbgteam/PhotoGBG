using DataAccess.Entities;
using DataAccessAbstraction.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Adapter
{
    public class TagAdapter
    {
    //{
    //    public ITag GetItem(DataRow dataRow)
        //{
        //    try
        //    {
        //        if (dataRow == null) return null;

        //        ITag returnValue = new Tag();
        //        if (dataRow.Rows.Count > 0)
        //        {
        //            Guid recordId;
        //            if (dt.Rows[0].Table.Columns.Contains("RecordID") && dt.Rows[0]["RecordID"] != null && Guid.TryParse(dt.Rows[0]["RecordID"].ToString(), out recordId))
        //            {
        //                retVal.RecordId = recordId;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        public List<ITag> GetItems(DataTable dt)
        {
            try
            {
                List<ITag> tags = new List<ITag>(10);
               
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int id;
                        ITag tag = new Tag();
                        if (dt.Rows[i].Table.Columns.Contains("ID") && dt.Rows[i]["ID"] != null && Int32.TryParse(dt.Rows[i]["ID"].ToString(),out id))
                        {
                            tag.Id = id;
                        }
                        if (dt.Rows[i].Table.Columns.Contains("Name") && dt.Rows[i]["Name"] != null)
                        {
                            tag.Name = dt.Rows[i]["Name"].ToString();
                        }
                        if (dt.Rows[i].Table.Columns.Contains("AddedBy") && dt.Rows[i]["AddedBy"] != null)
                        {
                            tag.AddedBy = dt.Rows[i]["AddedBy"].ToString();
                        }
                        tags.Add(tag);
                    }
                        return tags;
                }

                else return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
