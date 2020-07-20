using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLHSNV
{
    class ketnoi
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOPVTCVN-PC\SQLEXPRESS
            ;Initial Catalog=QLHoSoNV;Integrated Security=True");
        DataTable dt;

        public DataTable Timkiem(string manv)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "timkiem";
            SqlCommand comd = new SqlCommand(sql, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NChar)).Value = manv;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable loadttcanhan(string manv)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "loadttcanhan";
            SqlCommand comd = new SqlCommand(sql, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NChar)).Value = manv;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public void loadvungmien(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loadvungmien";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public DataTable Vungmien(string diachi)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "vungmien";
            SqlCommand comd = new SqlCommand(sql, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("diachi", SqlDbType.NChar)).Value = diachi;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public void loadtrinhdo(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loadtrinhdo";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public DataTable TrinhDo(string tentd)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "TrinhDo";
            SqlCommand comd = new SqlCommand(sql, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("tentd", SqlDbType.NChar)).Value = tentd;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void loadbcKyLuat(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loadbcKyLuat";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public DataTable bcKyLuat(string MKL)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "bcKyLuat";
            SqlCommand comd = new SqlCommand(sql, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("MKL", SqlDbType.NChar)).Value = MKL;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }



        public void loadbcKhenthuong(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loadbcKhenthuong";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public DataTable bcKhenTHuong(string MKT)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "bcKhenTHuong";
            SqlCommand comd = new SqlCommand(sql, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("MKT", SqlDbType.NChar)).Value = MKT;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }






        /// <summary>
        /// 
        /// </summary>
        /// <param name="madt"></param>
        /// <param name="manv"></param>
        /// <param name="tendt"></param>
        /// <param name="ngaybd"></param>
        /// <param name="ngaykt"></param>
        /// <param name="mota"></param>
        public void LoadCSDLchoQTDT(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loadQTDT";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void ThemCSDLqtdt(string madt, string manv, string ngaybd, string ngaykt,string mota)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "themdulieubangqtdt";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("madt", SqlDbType.NChar)).Value = madt;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NVarChar)).Value = manv;
                comd.Parameters.Add(new SqlParameter("ngaybd", SqlDbType.Date)).Value = ngaybd;
                comd.Parameters.Add(new SqlParameter("ngaykt", SqlDbType.Date)).Value = ngaykt;
                comd.Parameters.Add(new SqlParameter("mota", SqlDbType.NVarChar)).Value = mota;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                MessageBox.Show("Thêm không thành công!");
            }
            finally
            {
                con.Close();
            }

        }

        public void SuaCSDLqtdt(string madt, string manv, string ngaybd, string ngaykt,string mota)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "suadulieubangqtdt";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("madt", SqlDbType.NChar)).Value = madt;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NChar)).Value = manv;
                comd.Parameters.Add(new SqlParameter("ngaybd", SqlDbType.Date)).Value = ngaybd;
                comd.Parameters.Add(new SqlParameter("ngaykt", SqlDbType.Date)).Value = ngaykt;
                comd.Parameters.Add(new SqlParameter("mota", SqlDbType.NChar)).Value = mota;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public void XoaCSDLqtdt(string madt)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "xoadulieubangqtdt";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("madt", SqlDbType.NChar)).Value = madt;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="hoten"></param>
        /// <param name="gt"></param>
        /// <param name="ns"></param>
        /// <param name="dt"></param>
        /// <param name="dc"></param>
        /// <param name="sdt"></param>
        /// <param name="luongcb"></param>
        /// <param name="luongpc"></param>
        /// <param name="heso"></param>
        /// <param name="phongban"></param>
        /// <param name="chucvu"></param>
        /// <param name="tdhv"></param>
        /// <param name="ngaynhanchuc"></param>

        public void LoadCSDL(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loadnhanvien";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }
        public void ThemCSDLnhanvien(string manv, string hoten, string gt, string ns, string dt, string dc, 
            string sdt,string luongcb,string luongpc,string heso,string phongban,string chucvu,string tdhv,
            string ngaynhanchuc )
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "themdulieubangnhanvien";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NChar)).Value = manv;
                comd.Parameters.Add(new SqlParameter("hotennv", SqlDbType.NVarChar)).Value = hoten;              
                comd.Parameters.Add(new SqlParameter("gt", SqlDbType.NChar)).Value = gt;
                comd.Parameters.Add(new SqlParameter("ns", SqlDbType.Date)).Value = ns;
                comd.Parameters.Add(new SqlParameter("dt", SqlDbType.NChar)).Value = dt;
                comd.Parameters.Add(new SqlParameter("dc", SqlDbType.NVarChar)).Value = dc;
                comd.Parameters.Add(new SqlParameter("sdt", SqlDbType.NChar)).Value = sdt;
                comd.Parameters.Add(new SqlParameter("luongcb", SqlDbType.Money)).Value = luongcb;
                comd.Parameters.Add(new SqlParameter("luongpc", SqlDbType.Money)).Value = luongpc;
                comd.Parameters.Add(new SqlParameter("heso", SqlDbType.Float)).Value = heso;
                comd.Parameters.Add(new SqlParameter("phongban", SqlDbType.NVarChar)).Value = phongban;
                comd.Parameters.Add(new SqlParameter("chucvu", SqlDbType.NVarChar)).Value = chucvu;
                comd.Parameters.Add(new SqlParameter("tdhv", SqlDbType.NChar)).Value = tdhv;
                comd.Parameters.Add(new SqlParameter("ngaynhanchuc", SqlDbType.Date)).Value = ngaynhanchuc;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                MessageBox.Show("Thêm không thành công!");
                
               
            }
            finally
            {
                con.Close();
            }

        }
        public void SuaCSDLnhanvien(string manv, string hoten, string gt, string ns, string dt, string dc,
            string sdt, string luongcb, string luongpc, string heso, string phongban, string chucvu, string tdhv,
            string ngaynhanchuc)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "suadulieubangnhanvien";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NChar)).Value = manv;
                comd.Parameters.Add(new SqlParameter("hotennv", SqlDbType.NVarChar)).Value = hoten;
                comd.Parameters.Add(new SqlParameter("gt", SqlDbType.NChar)).Value = gt;
                comd.Parameters.Add(new SqlParameter("ns", SqlDbType.Date)).Value = ns;
                comd.Parameters.Add(new SqlParameter("dt", SqlDbType.NChar)).Value = dt;
                comd.Parameters.Add(new SqlParameter("dc", SqlDbType.NVarChar)).Value = dc;
                comd.Parameters.Add(new SqlParameter("sdt", SqlDbType.NChar)).Value = sdt;
                comd.Parameters.Add(new SqlParameter("luongcb", SqlDbType.Money)).Value = luongcb;
                comd.Parameters.Add(new SqlParameter("luongpc", SqlDbType.Money)).Value = luongpc;
                comd.Parameters.Add(new SqlParameter("heso", SqlDbType.Float)).Value = heso;
                comd.Parameters.Add(new SqlParameter("phongban", SqlDbType.NVarChar)).Value = phongban;
                comd.Parameters.Add(new SqlParameter("chucvu", SqlDbType.NVarChar)).Value = chucvu;
                comd.Parameters.Add(new SqlParameter("tdhv", SqlDbType.NChar)).Value = tdhv;
                comd.Parameters.Add(new SqlParameter("ngaynhanchuc", SqlDbType.Date)).Value = ngaynhanchuc;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void XoaCSDLnhanvien(string manv)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "xoadulieubangnhanvien";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NChar)).Value = manv;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="makt"></param>
        /// <param name="manv"></param>
        /// <param name="khenthuong"></param>
        /// <param name="ngaykhenthuong"></param>
        /// 
        public void LoadCSDLchoKT(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loadKhenThuong";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void ThemCSDLkhenthuong(string makt, string manv, string khenthuong, string ngaykhenthuong)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "themdulieubangkhenthuong";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("makt", SqlDbType.NChar)).Value = makt;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NVarChar)).Value = manv;
                comd.Parameters.Add(new SqlParameter("khenthuong", SqlDbType.NChar)).Value = khenthuong;
                comd.Parameters.Add(new SqlParameter("ngaykhenthuong", SqlDbType.Date)).Value = ngaykhenthuong;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                MessageBox.Show("Thêm không thành công!");
            }
            finally
            {
                con.Close();
            }

        }
        public void SuaCSDLkhenthuong(string makt, string manv, string khenthuong, string ngaykhenthuong)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "suadulieubangkhenthuong";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("makt", SqlDbType.NChar)).Value = makt;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NVarChar)).Value = manv;
                comd.Parameters.Add(new SqlParameter("khenthuong", SqlDbType.NChar)).Value = khenthuong;
                comd.Parameters.Add(new SqlParameter("ngaykhenthuong", SqlDbType.Date)).Value = ngaykhenthuong;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public void XoaCSDLkhenthuong(string makt)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "xoadulieubangkhenthuong";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("makt", SqlDbType.NChar)).Value = makt;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }


        /// <summary>

        /// </summary>
        /// <param name="makt"></param>
        /// <param name="manv"></param>
        /// <param name="khenthuong"></param>
        /// <param name="ngaykhenthuong"></param>
        public void LoadCSDLchoKL(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loadKyLuat";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void ThemCSDLkyluat(string makl, string manv, string kyluat, string ngaykl)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "themdulieubangkyluat";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("makl", SqlDbType.NChar)).Value = makl;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NVarChar)).Value = manv;
                comd.Parameters.Add(new SqlParameter("kyluat", SqlDbType.NChar)).Value = kyluat;
                comd.Parameters.Add(new SqlParameter("ngaykyluat", SqlDbType.Date)).Value = ngaykl;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                MessageBox.Show("Thêm không thành công!");
            }
            finally
            {
                con.Close();
            }

        }

        public void SuaCSDLkyluat(string makl, string manv, string kyluat, string ngaykl)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "suadulieubangkyluat";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("makl", SqlDbType.NChar)).Value = makl;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NVarChar)).Value = manv;
                comd.Parameters.Add(new SqlParameter("kyluat", SqlDbType.NChar)).Value = kyluat;
                comd.Parameters.Add(new SqlParameter("ngaykyluat", SqlDbType.Date)).Value = ngaykl;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public void XoaCSDLkyluat(string makl)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "xoadulieubangkyluat";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("makl", SqlDbType.NChar)).Value = makl;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mact"></param>
        /// <param name="manv"></param>
        /// <param name="tenct"></param>
        /// <param name="ngaybd"></param>
        /// <param name="ngaykt"></param>
        public void LoadCSDLchoQTCT(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loadQTCT";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void ThemCSDLqtct(string mact, string manv, string tenct, string ngaybd,string ngaykt)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "themdulieubangqtct";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("mact", SqlDbType.NChar)).Value = mact;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NVarChar)).Value = manv;
                comd.Parameters.Add(new SqlParameter("tenct", SqlDbType.NChar)).Value = tenct;
                comd.Parameters.Add(new SqlParameter("ngaybd", SqlDbType.Date)).Value = ngaybd;
                comd.Parameters.Add(new SqlParameter("ngaykt", SqlDbType.Date)).Value = ngaykt;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                MessageBox.Show("Thêm không thành công!");
            }
            finally
            {
                con.Close();
            }

        }

        public void SuaCSDLqtct(string mact, string manv, string tenct, string ngaybd, string ngaykt)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "suadulieubangqtct";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("mact", SqlDbType.NChar)).Value = mact;
                comd.Parameters.Add(new SqlParameter("manv", SqlDbType.NChar)).Value = manv;
                comd.Parameters.Add(new SqlParameter("tenct", SqlDbType.NChar)).Value = tenct;
                comd.Parameters.Add(new SqlParameter("ngaybd", SqlDbType.Date)).Value = ngaybd;
                comd.Parameters.Add(new SqlParameter("ngaykt", SqlDbType.Date)).Value = ngaykt;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public void XoaCSDLqtct(string mact)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "xoadulieubangqtct";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("mact", SqlDbType.NChar)).Value = mact;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }


        ////////// Độ tuổi////////

        public void LoadCSDLchoDotuoi(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loaddotuoi";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void LoadCSDLchoTuoithanhnien(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "dotuoithanhnien";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }


        public void LoadCSDLchoTuoitrungnien(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "dotuoitrungnien";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }


        public void LoadCSDLchoTuoicaonien(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "dotuoicaonien";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

    }
}