using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class ThongKeDAO
    {
        
        public static DataTable ThongKeNVTheoPhongBan(int idpb)
        {
            string query = "SELECT N.HOTEN, N.GIOITINH, N.CHUCVUID, N.PHONGBANID, C.TEN AS TENCV, P.TEN AS TENPB, G.TEN AS TENGIOITINH  FROM NHANVIEN N, GIOITINH G, CHUCVU C, PHONGBAN P WHERE N.PHONGBANID = " + idpb + " AND N.CHUCVUID = C.CHUCVUID AND N.GIOITINH = G.GIOITINHID AND N.PHONGBANID = P.PHONGBANID";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static DataTable ThongKeNVTheoChucVu(int idcv)
        {
            string query = "SELECT N.HOTEN, N.GIOITINH, N.CHUCVUID, N.PHONGBANID, C.TEN AS TENCV, P.TEN AS TENPB, G.TEN AS TENGIOITINH  FROM NHANVIEN N, GIOITINH G, CHUCVU C, PHONGBAN P WHERE N.CHUCVUID = " + idcv + " AND N.CHUCVUID = C.CHUCVUID AND N.GIOITINH = G.GIOITINHID AND N.PHONGBANID = P.PHONGBANID";

            return SqlServerHelper.ExecuteQuery(query);
        }
    }
}
