Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data

Namespace Constraction_Management_Co
    Public Class CLS_login
        Public Function Login(ByVal ID As String, ByVal PSW As String) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim param() As SqlParameter = New SqlParameter(1) {}

            param(0) = New SqlParameter("@ID", SqlDbType.VarChar, 30)
            param(0).Value = ID
            param(1) = New SqlParameter("@PSW", SqlDbType.VarChar, 30)
            param(1).Value = PSW

            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("SP_LOGIN", param)
            DAL.close()
            Return Dt
        End Function
        Public Function add_User(ByVal ID As String, ByVal U_NAME As String, ByVal U_FullName As String, ByVal PWS As String, ByVal U_TYPE As String, ByVal SIG As Byte()) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim param() As SqlParameter = New SqlParameter(5) {}

            param(0) = New SqlParameter("@ID", SqlDbType.VarChar, 50)
            param(0).Value = ID
            param(1) = New SqlParameter("@U_NAME", SqlDbType.NVarChar, 50)
            param(1).Value = U_NAME
            param(2) = New SqlParameter("@U_FullName", SqlDbType.NVarChar, 50)
            param(2).Value = U_FullName
            param(3) = New SqlParameter("@PWS", SqlDbType.VarChar, 50)
            param(3).Value = PWS
            param(4) = New SqlParameter("@U_TYPE", SqlDbType.VarChar, 50)
            param(4).Value = U_TYPE
            param(5) = New SqlParameter("@SIG", SqlDbType.Image)
            param(5).Value = SIG

            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("add_User", param)
            DAL.close()
            Return Dt
        End Function

        Public Function add_User_no_pic(ByVal ID As String, ByVal U_NAME As String, ByVal U_FullName As String, ByVal PWS As String, ByVal U_TYPE As String) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim param() As SqlParameter = New SqlParameter(4) {}

            param(0) = New SqlParameter("@ID", SqlDbType.VarChar, 50)
            param(0).Value = ID
            param(1) = New SqlParameter("@U_NAME", SqlDbType.NVarChar, 50)
            param(1).Value = U_NAME
            param(2) = New SqlParameter("@U_FullName", SqlDbType.NVarChar, 50)
            param(2).Value = U_FullName
            param(3) = New SqlParameter("@PWS", SqlDbType.VarChar, 50)
            param(3).Value = PWS
            param(4) = New SqlParameter("@U_TYPE", SqlDbType.VarChar, 50)
            param(4).Value = U_TYPE


            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("add_User_no_pic", param)
            DAL.close()
            Return Dt
        End Function

        Public Function get_all_users() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("get_all_users", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function Edite_User(ByVal ID As String, ByVal U_NAME As String, ByVal U_FullName As String, ByVal PWS As String, ByVal U_TYPE As String, ByVal SIG As Byte()) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim param() As SqlParameter = New SqlParameter(5) {}

            param(0) = New SqlParameter("@ID", SqlDbType.VarChar, 50)
            param(0).Value = ID
            param(1) = New SqlParameter("@U_NAME", SqlDbType.NVarChar, 50)
            param(1).Value = U_NAME
            param(2) = New SqlParameter("@U_FullName", SqlDbType.NVarChar, 50)
            param(2).Value = U_FullName
            param(3) = New SqlParameter("@PWS", SqlDbType.VarChar, 50)
            param(3).Value = PWS
            param(4) = New SqlParameter("@U_TYPE", SqlDbType.VarChar, 50)
            param(4).Value = U_TYPE
            param(5) = New SqlParameter("@SIG", SqlDbType.Image)
            param(5).Value = SIG

            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("Edite_User", param)

            DAL.close()
            Return Dt
        End Function
        Public Function Delete_User(ByVal ID As String) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim param() As SqlParameter = New SqlParameter(0) {}

            param(0) = New SqlParameter("@ID", SqlDbType.VarChar, 50)
            param(0).Value = ID

            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("Delete_User", param)
            DAL.close()
            Return Dt
        End Function

        Public Function get_ONE_users(ByVal D1 As Integer) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim param() As SqlParameter = New SqlParameter(0) {}

            param(0) = New SqlParameter("@D1", SqlDbType.Int)
            param(0).Value = D1

            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("get_ONE_users", param)
            DAL.close()
            Return Dt

        End Function

        Public Function VErfiy_ID(ByVal ID As Integer) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim param() As SqlParameter = New SqlParameter(0) {}

            param(0) = New SqlParameter("@ID", SqlDbType.Int)
            param(0).Value = ID

            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("VErfiy_ID", param)
            DAL.close()
            Return Dt
        End Function

        Public Function GET_ID_USER() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("GET_ID_USER", Nothing)
            DAL.close()
            Return DT
        End Function
        Public Function GET_S_NO() As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim DT As DataTable = New DataTable()
            DT = DAL.selectData("GET_S_NO", Nothing)
            DAL.close()
            Return DT
        End Function

        Public Function ADD_S_NO(ByVal ID As String) As DataTable
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim param() As SqlParameter = New SqlParameter(0) {}

            param(0) = New SqlParameter("@ID", SqlDbType.VarChar, 50)
            param(0).Value = ID

            Dim Dt As DataTable = New DataTable()
            Dt = DAL.selectData("ADD_S_NO", param)
            DAL.close()
            Return Dt
        End Function
    End Class
End Namespace
