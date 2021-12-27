Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data

Namespace Constraction_Management_Co
    Public Class CLS_Bills
        Public Sub Add_Cars(ByVal C_NAME As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@C_NAME", SqlDbType.NVarChar, 50)
            parm(0).Value = C_NAME

            DAL.ExecuteCommand("Add_Cars", parm)
            DAL.close()
        End Sub
        Public Sub Add_Maintance(ByVal M_name As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@M_name", SqlDbType.NVarChar, 50)
            parm(0).Value = M_name

            DAL.ExecuteCommand("Add_Maintance", parm)
            DAL.close()
        End Sub
        Public Function Fill_combo_maintance() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("Fill_combo_maintance", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function fill_combo_car() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("fill_combo_car", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Function get_all_Car_Bills() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_Car_Bills", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Sub Add_Carbills(ByVal ID As Integer, ByVal C_ID As Integer, ByRef M_ID As Integer, ByVal C_DATE As Date, ByVal T_MONY As String, ByVal FLAG As String, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(7) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@C_ID", SqlDbType.Int)
            parm(1).Value = C_ID
            parm(2) = New SqlParameter("@M_ID", SqlDbType.Int)
            parm(2).Value = M_ID
            parm(3) = New SqlParameter("@C_DATE", SqlDbType.Date)
            parm(3).Value = C_DATE
            parm(4) = New SqlParameter("@T_MONY", SqlDbType.VarChar, 25)
            parm(4).Value = T_MONY
            parm(5) = New SqlParameter("@FLAG", SqlDbType.NVarChar, 50)
            parm(5).Value = FLAG
            parm(6) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(6).Value = D1
            parm(7) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(7).Value = D2


            DAL.ExecuteCommand("Add_Carbills", parm)
            DAL.close()
        End Sub

        Public Sub EDIT_CARBILLS(ByVal ID As Integer, ByVal C_ID As Integer, ByRef M_ID As Integer, ByVal C_DATE As Date, ByVal T_MONY As String, ByVal FLAG As String, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(7) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@C_ID", SqlDbType.Int)
            parm(1).Value = C_ID
            parm(2) = New SqlParameter("@M_ID", SqlDbType.Int)
            parm(2).Value = M_ID
            parm(3) = New SqlParameter("@C_DATE", SqlDbType.Date)
            parm(3).Value = C_DATE
            parm(4) = New SqlParameter("@T_MONY", SqlDbType.VarChar, 25)
            parm(4).Value = T_MONY
            parm(5) = New SqlParameter("@FLAG", SqlDbType.NVarChar, 50)
            parm(5).Value = FLAG
            parm(6) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(6).Value = D1
            parm(7) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(7).Value = D2
            DAL.ExecuteCommand("EDIT_CARBILLS", parm)
            DAL.close()
        End Sub
        Public Function get_id_carbills() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_id_carbills", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Function grt_id_buildbills() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("grt_id_buildbills", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function get_id_bills() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_id_bills", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Sub Add_bills(ByVal ID As Integer, ByVal FLAG As String, ByVal C_ID As String, ByRef P_ID As String, ByVal T_MONY As String, ByVal P_MONY As String, ByVal L_MONY As String, ByVal B_DATE As Date, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(9) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@FLAG", SqlDbType.NVarChar, 50)
            parm(1).Value = FLAG
            parm(2) = New SqlParameter("@C_ID", SqlDbType.NVarChar, 50)
            parm(2).Value = C_ID
            parm(3) = New SqlParameter("@P_ID", SqlDbType.NVarChar, 50)
            parm(3).Value = P_ID
            parm(4) = New SqlParameter("@T_MONY", SqlDbType.VarChar, 25)
            parm(4).Value = T_MONY
            parm(5) = New SqlParameter("@P_MONY", SqlDbType.VarChar, 25)
            parm(5).Value = P_MONY
            parm(6) = New SqlParameter("@L_MONY", SqlDbType.VarChar, 25)
            parm(6).Value = L_MONY
            parm(7) = New SqlParameter("@B_DATE", SqlDbType.Date)
            parm(7).Value = B_DATE
            parm(8) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(8).Value = D1
            parm(9) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(9).Value = D2

            DAL.ExecuteCommand("Add_bills", parm)
            DAL.close()
        End Sub

        Public Sub edite_bills1(ByVal ID As Integer, ByVal FLAG As String, ByVal C_ID As String, ByRef P_ID As String, ByVal T_MONY As String, ByVal P_MONY As String, ByVal L_MONY As String, ByVal B_DATE As Date, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(9) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@FLAG", SqlDbType.NVarChar, 50)
            parm(1).Value = FLAG
            parm(2) = New SqlParameter("@C_ID", SqlDbType.NVarChar, 50)
            parm(2).Value = C_ID
            parm(3) = New SqlParameter("@P_ID", SqlDbType.NVarChar, 50)
            parm(3).Value = P_ID
            parm(4) = New SqlParameter("@T_MONY", SqlDbType.VarChar, 25)
            parm(4).Value = T_MONY
            parm(5) = New SqlParameter("@P_MONY", SqlDbType.VarChar, 25)
            parm(5).Value = P_MONY
            parm(6) = New SqlParameter("@L_MONY", SqlDbType.VarChar, 25)
            parm(6).Value = L_MONY
            parm(7) = New SqlParameter("@B_DATE", SqlDbType.Date)
            parm(7).Value = B_DATE
            parm(8) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(8).Value = D1
            parm(9) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(9).Value = D2

            DAL.ExecuteCommand("edite_bills1", parm)
            DAL.close()
        End Sub
      
        Public Function GET_ALL_BILL() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("GET_ALL_BILL", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Sub ADD_MBILLS(ByVal M_NAME As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@M_NAME", SqlDbType.NVarChar, 50)
            parm(0).Value = M_NAME

            DAL.ExecuteCommand("ADD_MBILLS", parm)
            DAL.close()
        End Sub
        Public Function get_id_sbill() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_id_sbill", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Function fill_comb_Sbill() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("fill_comb_Sbill", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function get_all_sbill() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_sbill", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Sub ADD_Sbill(ByVal ID As Integer, ByVal M_id As Integer, ByVal S_date As Date, ByVal Flag As String, ByVal T_mony As String, ByRef D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(6) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@M_id", SqlDbType.Int)
            parm(1).Value = M_id
            parm(2) = New SqlParameter("@S_date", SqlDbType.Date)
            parm(2).Value = S_date
            parm(3) = New SqlParameter("@Flag", SqlDbType.NVarChar, 100)
            parm(3).Value = Flag
            parm(4) = New SqlParameter("@T_mony", SqlDbType.VarChar, 25)
            parm(4).Value = T_mony
            parm(5) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(5).Value = D1
            parm(6) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(6).Value = D2

            DAL.ExecuteCommand("ADD_Sbill", parm)
            DAL.close()
        End Sub

        Public Sub EDIT_SBILL(ByVal ID As Integer, ByVal M_id As Integer, ByVal S_date As Date, ByVal Flag As String, ByVal T_mony As String, ByRef D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(6) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@M_id", SqlDbType.Int)
            parm(1).Value = M_id
            parm(2) = New SqlParameter("@S_date", SqlDbType.Date)
            parm(2).Value = S_date
            parm(3) = New SqlParameter("@Flag", SqlDbType.NVarChar, 100)
            parm(3).Value = Flag
            parm(4) = New SqlParameter("@T_mony", SqlDbType.VarChar, 25)
            parm(4).Value = T_mony
            parm(5) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(5).Value = D1
            parm(6) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(6).Value = D2

            DAL.ExecuteCommand("EDIT_SBILL", parm)
            DAL.close()
        End Sub

        Public Function fill_x_worker() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("fill_x_worker", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Sub Add_payment_2(ByVal ID As Integer, ByVal X_ID As Integer, ByVal PRO_N As String, ByVal S_ID As Integer, ByVal P_NAME As String, ByVal A_MONY As String, ByVal P_DATE As Date, ByVal D1 As String, ByVal D2 As Date, ByVal D3 As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(9) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@X_id", SqlDbType.Int)
            parm(1).Value = X_ID
            parm(2) = New SqlParameter("@PRO_N", SqlDbType.NVarChar, 50)
            parm(2).Value = PRO_N
            parm(3) = New SqlParameter("@S_ID", SqlDbType.Int)
            parm(3).Value = S_ID
            parm(4) = New SqlParameter("@P_NAME", SqlDbType.NVarChar, 50)
            parm(4).Value = P_NAME
            parm(5) = New SqlParameter("@A_MONY", SqlDbType.VarChar, 25)
            parm(5).Value = A_MONY
            parm(6) = New SqlParameter("@P_DATE", SqlDbType.Date)
            parm(6).Value = P_DATE
            parm(7) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(7).Value = D1
            parm(8) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(8).Value = D2
            parm(9) = New SqlParameter("@D3", SqlDbType.NVarChar, 50)
            parm(9).Value = D3

            DAL.ExecuteCommand("Add_payment_2", parm)
            DAL.close()
        End Sub
        Public Sub Edite_Payment(ByVal ID As Integer, ByVal X_id As Integer, ByVal P_NAME As String, ByVal A_MONY As String, ByVal P_DATE As Date, ByVal P_ID As Integer, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(7) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@X_id", SqlDbType.Int)
            parm(1).Value = X_id
            parm(2) = New SqlParameter("@P_NAME", SqlDbType.NVarChar, 50)
            parm(2).Value = P_NAME
            parm(3) = New SqlParameter("@A_MONY", SqlDbType.VarChar, 25)
            parm(3).Value = A_MONY
            parm(4) = New SqlParameter("@P_DATE", SqlDbType.Date)
            parm(4).Value = P_DATE
            parm(5) = New SqlParameter("@P_ID", SqlDbType.Int)
            parm(5).Value = P_ID
            parm(6) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(6).Value = D1
            parm(7) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(7).Value = D2

            DAL.ExecuteCommand("Edite_Payment", parm)
            DAL.close()
        End Sub
        Public Function get_id_pay_bills() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_id_pay_bills", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Function get_B_pay_name() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_B_pay_name", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Function get_mony_bills(ByVal D1 As Integer) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()

            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@D1", SqlDbType.Int)
            parm(0).Value = D1

            DT = DAL.selectData("get_mony_bills", parm)
            Return DT
        End Function

        Public Sub update_paid_pay(ByVal D1 As Integer, ByVal D2 As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(1) {}

            parm(0) = New SqlParameter("@D1", SqlDbType.Int)
            parm(0).Value = D1
            parm(1) = New SqlParameter("@D2", SqlDbType.VarChar, 25)
            parm(1).Value = D2

            DAL.ExecuteCommand("update_paid_pay", parm)
            DAL.close()
        End Sub

        Public Sub update_paid_pay_case_del(ByVal D1 As Integer, ByVal D2 As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(1) {}

            parm(0) = New SqlParameter("@D1", SqlDbType.Int)
            parm(0).Value = D1
            parm(1) = New SqlParameter("@D2", SqlDbType.VarChar, 25)
            parm(1).Value = D2

            DAL.ExecuteCommand("update_paid_pay_case_del", parm)
            DAL.close()
        End Sub
        Public Function GET_PayMENT_bills() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("GET_PayMENT_bills", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Sub Edite_pay_bills(ByVal ID As Integer, ByVal B_ID As Integer, ByVal P_MONEY As String, ByVal NOTE As String, ByVal P_DATE As Date, ByVal D1 As String, ByVal D2 As Date, ByVal D3 As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(7) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@B_ID", SqlDbType.Int)
            parm(1).Value = B_ID
            parm(2) = New SqlParameter("@P_MONEY", SqlDbType.VarChar, 25)
            parm(2).Value = P_MONEY
            parm(3) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 50)
            parm(3).Value = NOTE
            parm(4) = New SqlParameter("@P_DATE", SqlDbType.Date)
            parm(4).Value = P_DATE
            parm(5) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(5).Value = D1
            parm(6) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(6).Value = D2
            parm(7) = New SqlParameter("@D3", SqlDbType.NVarChar, 50)
            parm(7).Value = D3

            DAL.ExecuteCommand("Edite_pay_bills", parm)
            DAL.close()
        End Sub

        Public Sub Add_pay_bills(ByVal ID As Integer, ByVal B_ID As Integer, ByVal P_MONEY As String, ByVal NOTE As String, ByVal P_DATE As Date, ByVal D1 As String, ByVal D2 As Date, ByVal D3 As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(7) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@B_ID", SqlDbType.Int)
            parm(1).Value = B_ID
            parm(2) = New SqlParameter("@P_MONEY", SqlDbType.VarChar, 25)
            parm(2).Value = P_MONEY
            parm(3) = New SqlParameter("@NOTE", SqlDbType.NVarChar, 50)
            parm(3).Value = NOTE
            parm(4) = New SqlParameter("@P_DATE", SqlDbType.Date)
            parm(4).Value = P_DATE
            parm(5) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(5).Value = D1
            parm(6) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(6).Value = D2
            parm(7) = New SqlParameter("@D3", SqlDbType.NVarChar, 50)
            parm(7).Value = D3

            DAL.ExecuteCommand("Add_pay_bills", parm)
            DAL.close()
        End Sub

        Public Function MONEY_CONFIQ(ByVal ID As Integer, ByVal D1 As String) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()

            Dim parm As SqlParameter() = New SqlParameter(1) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@D1", SqlDbType.VarChar, 25)
            parm(1).Value = D1

            DT = DAL.selectData("MONEY_CONFIQ", parm)
            Return DT
        End Function

        Public Sub DELETE_PAY_BILS(ByVal ID As Integer)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID

            DAL.ExecuteCommand("DELETE_PAY_BILS", parm)
            DAL.close()
        End Sub
        Public Sub DELET_PAYMENT(ByVal ID As Integer)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID

            DAL.ExecuteCommand("DELET_PAYMENT", parm)
            DAL.close()
        End Sub
        Public Function GET_MONEY_X_WORKER(ByVal D1 As Integer, ByVal D2 As String, ByVal D3 As Integer) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            Dim parm As SqlParameter() = New SqlParameter(2) {}

            parm(0) = New SqlParameter("@D1", SqlDbType.Int)
            parm(0).Value = D1
            parm(1) = New SqlParameter("@D2", SqlDbType.NVarChar, 50)
            parm(1).Value = D2
            parm(2) = New SqlParameter("@D3", SqlDbType.Int)
            parm(2).Value = D3

            DT = DAL.selectData("GET_MONEY_X_WORKER", parm)
            Return DT
        End Function
        Public Sub update_paid_X_WORKER(ByVal D1 As Integer, ByVal D2 As Integer, ByVal D3 As String, ByVal D4 As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(3) {}

            parm(0) = New SqlParameter("@D1", SqlDbType.Int)
            parm(0).Value = D1
            parm(1) = New SqlParameter("@D2", SqlDbType.Int)
            parm(1).Value = D2
            parm(2) = New SqlParameter("@D3", SqlDbType.NVarChar, 50)
            parm(2).Value = D3
            parm(3) = New SqlParameter("@D4", SqlDbType.VarChar, 25)
            parm(3).Value = D4

            DAL.ExecuteCommand("update_paid_X_WORKER", parm)
            DAL.close()
        End Sub

        Public Sub update_X_paid_pay_case_del(ByVal D1 As Integer, ByVal D2 As Integer, ByVal D3 As String, ByVal D4 As String)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(3) {}

            parm(0) = New SqlParameter("@D1", SqlDbType.Int)
            parm(0).Value = D1
            parm(1) = New SqlParameter("@D2", SqlDbType.Int)
            parm(1).Value = D2
            parm(2) = New SqlParameter("@D3", SqlDbType.NVarChar, 50)
            parm(2).Value = D3
            parm(3) = New SqlParameter("@D4", SqlDbType.VarChar, 25)
            parm(3).Value = D4

            DAL.ExecuteCommand("update_X_paid_pay_case_del", parm)
            DAL.close()
        End Sub
        Public Function MONEY_X__CONFIQ(ByVal D1 As Integer, ByVal D2 As Integer, ByVal D3 As String, ByVal D4 As String) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            Dim parm As SqlParameter() = New SqlParameter(3) {}

            parm(0) = New SqlParameter("@D1", SqlDbType.Int)
            parm(0).Value = D1
            parm(1) = New SqlParameter("@D2", SqlDbType.Int)
            parm(1).Value = D2
            parm(2) = New SqlParameter("@D3", SqlDbType.NVarChar, 50)
            parm(2).Value = D3
            parm(3) = New SqlParameter("@D4", SqlDbType.VarChar, 25)
            parm(3).Value = D4

            DT = DAL.selectData("MONEY_X__CONFIQ", parm)
            Return DT
        End Function
        Public Function GET_TOTAL_PAYMENT(ByVal D1 As Integer, ByVal D3 As String) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            Dim parm As SqlParameter() = New SqlParameter(1) {}

            parm(0) = New SqlParameter("@D1", SqlDbType.Int)
            parm(0).Value = D1
            parm(1) = New SqlParameter("@D3", SqlDbType.NVarChar, 50)
            parm(1).Value = D3

            DT = DAL.selectData("GET_TOTAL_PAYMENT", parm)
            Return DT
        End Function

        Public Function GET_TOTAL_MONEY(ByVal ID As Integer) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID

            DT = DAL.selectData("GET_TOTAL_MONEY", parm)
            Return DT
        End Function
    End Class
End Namespace
