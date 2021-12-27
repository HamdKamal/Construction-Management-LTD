Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data

Namespace Constraction_Management_Co
    Public Class CLS_Resipet
        Public Function get_id_RES_PRO() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_id_RES_PRO", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function get_id_area() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_id_area", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Sub ADD_RES_AREA(ByVal ID As Integer, ByVal A_NAME As String, ByVal A_MONEY As String, ByVal Flag As String, ByVal A_DATE As Date, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(6) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@A_NAME", SqlDbType.NVarChar, 50)
            parm(1).Value = A_NAME
            parm(2) = New SqlParameter("@A_MONEY", SqlDbType.VarChar, 25)
            parm(2).Value = A_MONEY
            parm(3) = New SqlParameter("@Flag", SqlDbType.NVarChar, 100)
            parm(3).Value = Flag
            parm(4) = New SqlParameter("@A_DATE", SqlDbType.Date)
            parm(4).Value = A_DATE
            parm(5) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(5).Value = D1
            parm(6) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(6).Value = D2

            DAL.ExecuteCommand("ADD_RES_AREA", parm)
            DAL.close()
        End Sub

        Public Sub ADD_RES_PRO(ByVal ID As Integer, ByVal P_ID As String, ByVal P_MONEY As String, ByVal Flag As String, ByVal P_DATE As Date, ByVal D1 As String, ByVal D2 As Date)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(6) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID
            parm(1) = New SqlParameter("@P_ID", SqlDbType.NVarChar, 50)
            parm(1).Value = P_ID
            parm(2) = New SqlParameter("@P_MONEY", SqlDbType.VarChar, 25)
            parm(2).Value = P_MONEY
            parm(3) = New SqlParameter("@Flag", SqlDbType.NVarChar, 100)
            parm(3).Value = Flag
            parm(4) = New SqlParameter("@P_DATE", SqlDbType.Date)
            parm(4).Value = P_DATE
            parm(5) = New SqlParameter("@D1", SqlDbType.NVarChar, 50)
            parm(5).Value = D1
            parm(6) = New SqlParameter("@D2", SqlDbType.DateTime)
            parm(6).Value = D2

            DAL.ExecuteCommand("ADD_RES_PRO", parm)
            DAL.close()
        End Sub
        Public Sub DEL_RES_PRO(ByVal ID As Integer)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID

            DAL.ExecuteCommand("DEL_RES_PRO", parm)
            DAL.close()
        End Sub

        Public Sub DEL_RES_AREA(ByVal ID As Integer)
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            DAL.open()
            Dim parm As SqlParameter() = New SqlParameter(0) {}

            parm(0) = New SqlParameter("@ID", SqlDbType.Int)
            parm(0).Value = ID

            DAL.ExecuteCommand("DEL_RES_AREA", parm)
            DAL.close()
        End Sub

        Public Function GET_RES_PRO() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("GET_RES_PRO", Nothing)
            DAL.close()
            Return Dt
        End Function

        Public Function GET_RES_AREA() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("GET_RES_AREA", Nothing)
            DAL.close()
            Return Dt
        End Function

        Public Function GET_TOTAL_PRO() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("GET_TOTAL_PRO", Nothing)
            DAL.close()
            Return Dt
        End Function

        Public Function GET_TOTAL_AREA() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("GET_TOTAL_AREA", Nothing)
            DAL.close()
            Return Dt
        End Function

    End Class
End Namespace

