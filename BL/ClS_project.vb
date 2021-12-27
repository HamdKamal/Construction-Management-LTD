Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data

Namespace Constraction_Management_Co
    Public Class ClS_project
        Public Function get_all_projects() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_projects", Nothing)
            DAL.close()
            Return dt
        End Function
        Public Sub Add_Project(ByVal ID As Integer, ByVal P_NAME As String, ByVal P_LOCATIN As String, ByVal P_OWNER As String, ByVal P_TOTAL As String, ByVal P_START As DateTime, ByVal P_END As DateTime, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(8) {}
            parm(0) = New SqlParameter("@ID", SqlDbType.NVarChar, 50)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@P_NAME", SqlDbType.NVarChar, 50)
            parm(1).Value = P_NAME
            parm(2) = New SqlParameter("@P_LOCATIN", SqlDbType.NVarChar, 50)
            parm(2).Value = P_LOCATIN
            parm(3) = New SqlParameter("@P_OWNER", SqlDbType.NVarChar, 50)
            parm(3).Value = P_OWNER
            parm(4) = New SqlParameter("@P_TOTAL", SqlDbType.NVarChar, 25)
            parm(4).Value = P_TOTAL
            parm(5) = New SqlParameter("@P_START", SqlDbType.Date)
            parm(5).Value = P_START
            parm(6) = New SqlParameter("@P_END", SqlDbType.Date)
            parm(6).Value = P_END
            parm(7) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(7).Value = D1
            parm(8) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(8).Value = D2

            DAL.ExecuteCommand("Add_Project", parm)
            DAL.close()
        End Sub
        Public Sub Edite_Projects(ByVal ID As Integer, ByVal P_NAME As String, ByVal P_LOCATIN As String, ByVal P_OWNER As String, ByVal P_TOTAL As String, ByVal P_START As DateTime, ByVal P_END As DateTime, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(8) {}
            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@P_NAME", SqlDbType.NVarChar, 50)
            parm(1).Value = P_NAME
            parm(2) = New SqlParameter("@P_LOCATIN", SqlDbType.NVarChar, 50)
            parm(2).Value = P_LOCATIN
            parm(3) = New SqlParameter("@P_OWNER", SqlDbType.NVarChar, 50)
            parm(3).Value = P_OWNER
            parm(4) = New SqlParameter("@P_TOTAL", SqlDbType.NVarChar, 25)
            parm(4).Value = P_TOTAL
            parm(5) = New SqlParameter("@P_START", SqlDbType.Date)
            parm(5).Value = P_START
            parm(6) = New SqlParameter("@P_END", SqlDbType.Date)
            parm(6).Value = P_END
            parm(7) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(7).Value = D1
            parm(8) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(8).Value = D2


            DAL.ExecuteCommand("Edite_Projects", parm)
            DAL.close()
        End Sub
        Public Sub Delete_Project(ByVal ID As Integer)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
           
            DAL.ExecuteCommand("Delete_Project", parm)
            DAL.close()
        End Sub
        Public Sub add_main_catgeories(ByVal ID As Integer, ByVal C_NAME As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(1) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@C_NAME", SqlDbType.NVarChar, 50)
            parm(1).Value = C_NAME

            DAL.ExecuteCommand("add_main_catgeories", parm)
            DAL.close()
        End Sub
        Public Function get_last_id_project() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_last_id_project", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function get_all_mainCat() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_mainCat", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Sub edite_mainCat(ByVal ID As Integer, ByVal C_NAME As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(1) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@C_NAME", SqlDbType.NVarChar, 50)
            parm(1).Value = C_NAME


            DAL.ExecuteCommand("edite_mainCat", parm)
            DAL.close()
        End Sub
        Public Sub Delete_MainCat(ByVal ID As Integer)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID

            DAL.ExecuteCommand("Delete_MainCat", parm)
            DAL.close()
        End Sub

        Public Function fill_comb_mainCat() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("fill_comb_mainCat", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Sub Add_Sub_Cat(ByVal sub_id As Integer, ByVal main_id As Integer, ByVal sub_name As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(2) {}

            parm(0) = New SqlParameter("@sub_id", SqlDbType.Int)
            parm(0).Value = sub_id
            parm(1) = New SqlParameter("@main_id", SqlDbType.Int)
            parm(1).Value = main_id
            parm(2) = New SqlParameter("@sub_name", SqlDbType.NVarChar, 50)
            parm(2).Value = sub_name

            DAL.ExecuteCommand("Add_Sub_Cat", parm)
            DAL.close()
        End Sub
        Public Function get_last_id_SubCat() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_last_id_SubCat", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function get_all_SubCat() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_SubCat", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Function get_last_id_MainCat() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_last_id_MainCat", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Sub Del_SubCat(ByVal ID As Integer)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID

            DAL.ExecuteCommand("Del_SubCat", parm)
            DAL.close()
        End Sub
        Public Sub Edite_SubCat(ByVal sub_id As Integer, ByVal main_id As Integer, ByVal sub_name As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(2) {}

            parm(0) = New SqlParameter("@sub_id", SqlDbType.Int)
            parm(0).Value = sub_id
            parm(1) = New SqlParameter("@main_id", SqlDbType.Int)
            parm(1).Value = main_id
            parm(2) = New SqlParameter("@sub_name", SqlDbType.NVarChar, 50)
            parm(2).Value = sub_name

            DAL.ExecuteCommand("Edite_SubCat", parm)
            DAL.close()
        End Sub
        Public Function fill_combo_proj() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("fill_combo_proj", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function fill_combo_sub() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("fill_combo_sub", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Sub ADD_BUILD_BILLS(
                                   ByVal ID As Integer,
                                   ByVal P_ID As Integer,
                                   ByVal S_ID As Integer,
                                   ByVal QUN As String,
                                   ByVal B_PRICE As String,
                                   ByVal B_TOTAL As String,
                                   ByVal B_DATE As Date,
                                   ByVal FLAG As String,
                                   ByVal V_PRICE As String,
                                   ByVal V_VAL As String,
                                   ByVal C_ID As Integer,
                                   ByVal D1 As String,
                                   ByVal D2 As Date)


            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(12) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@P_ID", SqlDbType.Int)
            parm(1).Value = P_ID
            parm(2) = New SqlParameter("@S_ID", SqlDbType.Int)
            parm(2).Value = S_ID
            parm(3) = New SqlParameter("@QUN", SqlDbType.VarChar, 25)
            parm(3).Value = QUN
            parm(4) = New SqlParameter("@B_PRICE", SqlDbType.VarChar, 25)
            parm(4).Value = B_PRICE
            parm(5) = New SqlParameter("@B_TOTAL", SqlDbType.VarChar, 25)
            parm(5).Value = B_TOTAL
            parm(6) = New SqlParameter("@B_DATE", SqlDbType.Date)
            parm(6).Value = B_DATE
            parm(7) = New SqlParameter("@FLAG", SqlDbType.NVarChar, 100)
            parm(7).Value = FLAG
            parm(8) = New SqlParameter("@V_PRICE", SqlDbType.VarChar, 25)
            parm(8).Value = V_PRICE
            parm(9) = New SqlParameter("@V_VAL", SqlDbType.NVarChar, 50)
            parm(9).Value = V_VAL
            parm(10) = New SqlParameter("@C_ID", SqlDbType.Int)
            parm(10).Value = C_ID
            parm(11) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(11).Value = D1
            parm(12) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(12).Value = D2

            DAL.ExecuteCommand("ADD_BUILD_BILLS", parm)
            DAL.close()
        End Sub
        Public Sub EDIT_BUILD_BILLS(ByVal ID As Integer,
                                         ByVal P_ID As Integer,
                                         ByVal S_ID As Integer,
                                         ByVal QUN As String,
                                         ByVal B_PRICE As String,
                                         ByVal B_TOTAL As String,
                                         ByVal B_DATE As Date,
                                         ByVal FLAG As String,
                                         ByVal V_PRICE As String,
                                         ByVal V_VAL As String,
                                         ByVal C_ID As Integer,
                                         ByVal D1 As String,
                                         ByVal D2 As Date)

            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(12) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@P_ID", SqlDbType.Int)
            parm(1).Value = P_ID
            parm(2) = New SqlParameter("@S_ID", SqlDbType.Int)
            parm(2).Value = S_ID
            parm(3) = New SqlParameter("@QUN", SqlDbType.VarChar, 25)
            parm(3).Value = QUN
            parm(4) = New SqlParameter("@B_PRICE", SqlDbType.VarChar, 25)
            parm(4).Value = B_PRICE
            parm(5) = New SqlParameter("@B_TOTAL", SqlDbType.VarChar, 25)
            parm(5).Value = B_TOTAL
            parm(6) = New SqlParameter("@B_DATE", SqlDbType.Date)
            parm(6).Value = B_DATE
            parm(7) = New SqlParameter("@FLAG", SqlDbType.NVarChar, 100)
            parm(7).Value = FLAG
            parm(8) = New SqlParameter("@V_PRICE", SqlDbType.VarChar, 25)
            parm(8).Value = V_PRICE
            parm(9) = New SqlParameter("@V_VAL", SqlDbType.NVarChar, 50)
            parm(9).Value = V_VAL
            parm(10) = New SqlParameter("@C_ID", SqlDbType.Int)
            parm(10).Value = C_ID
            parm(11) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(11).Value = D1
            parm(12) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(12).Value = D2

            DAL.ExecuteCommand("EDIT_BUILD_BILLS", parm)
            DAL.close()
        End Sub
        Public Function get_all_buildbills() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_buildbills", Nothing)
            DAL.close()
            Return DT
        End Function
    End Class
End Namespace

