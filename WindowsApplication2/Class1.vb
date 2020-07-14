
Public Class CSDIEN
    Private mahd$
    Private makh$
    Private math$
    Private csc%
    Private csm%
    Private ldien$
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

    Public Property p_math$()
        Get
            Return math
        End Get
        Set(value$)
            math = value
        End Set
    End Property



    Public Property p_csc$()
        Get
            Return csc
        End Get
        Set(value$)
            csc = value
        End Set
    End Property


    Public Property p_csm$()
        Get
            Return csm
        End Get
        Set(value$)
            csm = value
        End Set
    End Property

    Public Property p_ldien$()
        Get
            Return ldien
        End Get
        Set(value$)
            ldien = value
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


    Public Sub New(mah$, mak$, mat$, cscu%, csmoi%, ld$, t&)
        mahd = mah
        makh = mak
        math = mat
        csc = cscu
        csm = csmoi
        ldien = ld
        tt = t
    End Sub

    Public Sub Luu(ByRef lenh$)
        lenh = "insert into CSDIEN(MAHD,MAKH,MATH,CSCU,CSMOI,LOAIDIEN,TIEN) values('" & mahd & "','" & makh & "','" &
          math & "'," & csc & "," & csm & ",N'" & ldien & "','" & tt & "')"
    End Sub

    Public Sub xoa(ByRef lenh$)
        lenh = "delete from CSDIEN where MAKH = '" & makh.Trim & "'"
    End Sub
    Public Sub sua(ByRef lenh$)
        lenh = "Update CSDIEN set MAHD='" & mahd & "',MAKH='" & makh & "',MATH= '" & math & "', CSCU =" & csc _
        & ", CSMOI=" & csm & ",LOAIDIEN=N'" & ldien & "',TIEN='" & tt & "'where MAKH ='" & makh.Trim & "'"
    End Sub
End Class

