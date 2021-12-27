Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data

Namespace Constraction_Management_Co
    Public Class ClS_employes
        Public Function get_all_employees() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_employees", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function get_last_id_employee() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_last_id_employee", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Sub add_Employess(ByVal ID As Integer, ByVal E_NAME As String, ByVal ST_ID As String, ByVal ST_END_DATE As Date, ByVal E_JOB As String, ByVal E_SALARY As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(5) {}
            parm(0) = New SqlParameter("@ID", SqlDbType.NVarChar, 50)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@E_NAME", SqlDbType.NVarChar, 50)
            parm(1).Value = E_NAME
            parm(2) = New SqlParameter("@ST_ID", SqlDbType.VarChar, 50)
            parm(2).Value = ST_ID
            parm(3) = New SqlParameter("@ST_END_DATE", SqlDbType.Date)
            parm(3).Value = ST_END_DATE
            parm(4) = New SqlParameter("@E_JOB", SqlDbType.NVarChar, 50)
            parm(4).Value = E_JOB
            parm(5) = New SqlParameter("@E_SALARY", SqlDbType.NVarChar, 25)
            parm(5).Value = E_SALARY

            DAL.ExecuteCommand("add_Employess", parm)
            DAL.close()
        End Sub
        Public Sub edite_EMployeess(ByVal ID As Integer, ByVal E_NAME As String, ByVal ST_ID As String, ByVal ST_END_DATE As Date, ByVal E_JOB As String, ByVal E_SALARY As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(5) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.NVarChar, 50)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@E_NAME", SqlDbType.NVarChar, 50)
            parm(1).Value = E_NAME
            parm(2) = New SqlParameter("@ST_ID", SqlDbType.VarChar, 50)
            parm(2).Value = ST_ID
            parm(3) = New SqlParameter("@ST_END_DATE", SqlDbType.Date)
            parm(3).Value = ST_END_DATE
            parm(4) = New SqlParameter("@E_JOB", SqlDbType.NVarChar, 50)
            parm(4).Value = E_JOB
            parm(5) = New SqlParameter("@E_SALARY", SqlDbType.NVarChar, 25)
            parm(5).Value = E_SALARY

            DAL.ExecuteCommand("edite_EMployeess", parm)
            DAL.close()
        End Sub
        Public Sub Delete_Emp(ByVal ID As Integer)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID

            DAL.ExecuteCommand("Delete_Emp", parm)
            DAL.close()
        End Sub

        Public Function get_all_workerPay() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_workerPay", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function fill_combo_emp() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("fill_combo_emp", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Sub Add_Worker_bills(ByVal ID As Integer, ByVal E_ID As Integer, ByVal P_ID As Integer, ByVal mony_Pay As String, ByVal DATE_PAY As Date, ByVal FLAG As String, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(7) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@E_ID", SqlDbType.Int)
            parm(1).Value = E_ID
            parm(2) = New SqlParameter("@P_ID", SqlDbType.Int)
            parm(2).Value = P_ID
            parm(3) = New SqlParameter("@mony_Pay", SqlDbType.VarChar, 25)
            parm(3).Value = mony_Pay
            parm(4) = New SqlParameter("@DATE_PAY", SqlDbType.Date)
            parm(4).Value = DATE_PAY
            parm(5) = New SqlParameter("@FLAG", SqlDbType.NVarChar, 50)
            parm(5).Value = FLAG
            parm(6) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(6).Value = D1
            parm(7) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(7).Value = D2

            DAL.ExecuteCommand("Add_Worker_bills", parm)
            DAL.close()
        End Sub
        Public Sub Edite_Workers_Bills(ByVal ID As Integer, ByVal E_ID As Integer, ByVal P_ID As Integer, ByVal mony_Pay As String, ByVal DATE_PAY As Date, ByVal FLAG As String, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(7) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@E_ID", SqlDbType.Int)
            parm(1).Value = E_ID
            parm(2) = New SqlParameter("@P_ID", SqlDbType.Int)
            parm(2).Value = P_ID
            parm(3) = New SqlParameter("@mony_Pay", SqlDbType.VarChar, 25)
            parm(3).Value = mony_Pay
            parm(4) = New SqlParameter("@DATE_PAY", SqlDbType.Date)
            parm(4).Value = DATE_PAY
            parm(5) = New SqlParameter("@FLAG", SqlDbType.NVarChar, 50)
            parm(5).Value = FLAG
            parm(6) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(6).Value = D1
            parm(7) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(7).Value = D2

            DAL.ExecuteCommand("Edite_Workers_Bills", parm)
            DAL.close()
        End Sub

        Public Function get_ID_workerbills() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_ID_workerbills", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function GET_ID_X_WORKER() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("GET_ID_X_WORKER", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Sub Add_xworker(ByVal ID As Integer, ByVal P_ID As String, ByVal x_id As Integer, ByVal C_ID As Integer, ByVal S_ID As Integer, ByVal B_MONY As String, ByVal D_PAY As Date, ByVal D1 As String, ByVal D2 As Date, ByVal M1 As String, ByVal M2 As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(10) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@P_ID", SqlDbType.NVarChar, 50)
            parm(1).Value = P_ID
            parm(2) = New SqlParameter("@x_id", SqlDbType.Int)
            parm(2).Value = x_id
            parm(3) = New SqlParameter("@C_ID", SqlDbType.Int)
            parm(3).Value = C_ID
            parm(4) = New SqlParameter("@S_ID", SqlDbType.Int)
            parm(4).Value = S_ID
            parm(5) = New SqlParameter("@B_MONY", SqlDbType.VarChar, 25)
            parm(5).Value = B_MONY
            parm(6) = New SqlParameter("@D_PAY", SqlDbType.Date)
            parm(6).Value = D_PAY
            parm(7) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(7).Value = D1
            parm(8) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(8).Value = D2
            parm(9) = New SqlParameter("@M1", SqlDbType.VarChar, 25)
            parm(9).Value = M1
            parm(10) = New SqlParameter("@M2", SqlDbType.VarChar, 25)
            parm(10).Value = M2
            DAL.ExecuteCommand("Add_xworker", parm)
            DAL.close()
        End Sub
        Public Sub EDIT_Xworker(ByVal ID As Integer, ByVal P_ID As String, ByVal x_id As Integer, ByVal C_ID As Integer, ByVal S_ID As Integer, ByVal B_MONY As String, ByVal D_PAY As Date, ByVal D1 As String, ByVal D2 As Date, ByVal M1 As String, ByVal M2 As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(10) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@P_ID", SqlDbType.NVarChar, 50)
            parm(1).Value = P_ID
            parm(2) = New SqlParameter("@x_id", SqlDbType.Int)
            parm(2).Value = x_id
            parm(3) = New SqlParameter("@C_ID", SqlDbType.Int)
            parm(3).Value = C_ID
            parm(4) = New SqlParameter("@S_ID", SqlDbType.Int)
            parm(4).Value = S_ID
            parm(5) = New SqlParameter("@B_MONY", SqlDbType.VarChar, 25)
            parm(5).Value = B_MONY
            parm(6) = New SqlParameter("@D_PAY", SqlDbType.Date)
            parm(6).Value = D_PAY
            parm(7) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(7).Value = D1
            parm(8) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(8).Value = D2
            parm(9) = New SqlParameter("@M1", SqlDbType.VarChar, 25)
            parm(9).Value = M1
            parm(10) = New SqlParameter("@M2", SqlDbType.VarChar, 25)
            parm(10).Value = M2
            DAL.ExecuteCommand("EDIT_Xworker", parm)
            DAL.close()
        End Sub
        Public Sub Delet_Xworker(ByVal ID As Integer)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID

            DAL.ExecuteCommand("Delet_Xworker", parm)
            DAL.close()
        End Sub

        Public Function GET_ID_PAYMENT() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("GET_ID_PAYMENT", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Function get_all_xworker() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_xworker", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Function get_all_payment() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_payment", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Function get_x_pro(ByVal ID As Integer) As DataTable




            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@id", SqlDbType.Int)
            parm(0).Value = ID
            DT = DAL.selectData("get_x_pro", parm)
            DAL.close()
            

            ' Dim x As New SqlDataReader
            '   DAL.sqlconn.Open()
            '  Dim cmd As New SqlCommand
            ' cmd.CommandType = CommandType.StoredProcedure
            ' cmd.Parameters.Add("@id", SqlDbType.Int)
            ' x = cmd.ExecuteReader
            ' Return x.Item(0)

            Return DT

        End Function

        Public Function fill_combo_xname() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("fill_combo_xname", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Sub add_xname(ByVal x_name As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@x_name", SqlDbType.NVarChar, 50)
            parm(0).Value = x_name


            DAL.ExecuteCommand("add_xname", parm)
            DAL.close()
        End Sub

    End Class
End Namespace

