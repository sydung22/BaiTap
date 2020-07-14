Public Class HD
    Private mahd$
    Private makh$
    Private ld$
    Private ldth%
    Private tt&
    Public Property p_mahd$()
        Get
            Return mahd
        End Get
        Set(value$)
            mahd = value
        End Set
    End Property

    Public Property p_makh$()
        Get
            Return makh
        End Get
        Set(value$)
            makh = value
        End Set
    End Property



    Public Property p_ld$()
        Get
            Return ld
        End Get
        Set(value$)
            ld = value
        End Set
    End Property

    Public Property p_ldth$()
        Get
            Return ldth
        End Get
        Set(value$)
            ldth = value
        End Set
    End Property

    Public Property p_tt$()
        Get
            Return tt
        End Get
        Set(value$)
            tt = value
        End Set
    End Property

    Public Sub New(mahd$, makh$, ldth%, ld$, tt&)
        mahd = mahd
        makh = makh
        ld = ld
        ldth = ldth
        tt = tt
    End Sub

    Public Sub Luu(ByRef lenh$)
        lenh = "insert into HDON(MAHD,MAKH,LDTH,LOAIDIEN,TIEN) values('" & mahd & "','" & makh & "'," & ldth & ",'" & ld & "'," & tt & ")"
    End Sub


    Public Sub xoa(ByRef lenh$)
        lenh = "delete from HDON where MAKH = '" & mahd.Trim & "'"
    End Sub
    Public Sub sua(ByRef lenh$)
        lenh = "Update HDON set MAHD='" & makh & "',MAKH= '" & mahd & "', LDTH =" & ldth _
    & ", LOAIDIEN=" & ld & ", TIEN=" & tt & " where MAHD ='" & mahd.Trim & "'"
    End Sub
End Class
