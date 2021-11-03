using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

/// <summary>
/// Business Layer of Degree data
/// </summary>
public class DegreeBusiness
{
    public DataTable GetDegreeList()
    {
        DegreeData degreeData = new DegreeData();
        return degreeData.GetDegreeListData();
    }

    public int InsertDegree(Degree degree)
    {
        DegreeData degreeData = new DegreeData();
        return degreeData.InsertDegreeData(degree.Title);
    }

    public int UpdateDegree(Degree degree)
    {
        DegreeData degreeData = new DegreeData();
        return degreeData.UpdateDegreeData(degree.ID, degree.Title);
    }
}
