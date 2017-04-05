﻿Public Class Investigador
    Private _idInvest As Integer
    Private _nombre As String
    Private _apellidos As String
    Private _despacho As String
    Private _edificio As String
    Private _departamento As String
    Private _telefono As Integer
    Private _email As String
    Private _articulo As Articulo
    Private _daoInvestigador As DAOInvestigador

    Public Sub New(ByVal idInvest As Integer)
        Me._idInvest = idInvest
        Me._daoInvestigador = New DAOInvestigador
    End Sub

    Public Sub New()
        Me._daoInvestigador = New DAOInvestigador
    End Sub

    Public Property IDInvestigador() As Integer
        Get
            Return Me._idInvest
        End Get
        Set(value As Integer)
            Me._idInvest = value
        End Set
    End Property


    Public Property Articulo() As Articulo
        Get
            Return Me._articulo
        End Get
        Set(value As Articulo)
            Me._articulo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property

    Public Property Apellidos() As String
        Get
            Return Me._apellidos
        End Get
        Set(value As String)
            Me._apellidos = value
        End Set
    End Property

    Public Property Despacho() As String
        Get
            Return Me._despacho
        End Get
        Set(value As String)
            Me._despacho = value
        End Set
    End Property

    Public Property Edificio() As String
        Get
            Return Me._edificio
        End Get
        Set(value As String)
            Me._edificio = value
        End Set
    End Property

    Public Property Departamento() As String
        Get
            Return Me._departamento
        End Get
        Set(value As String)
            Me._departamento = value
        End Set
    End Property

    Public Property Telefono() As Integer
        Get
            Return Me._telefono
        End Get
        Set(value As Integer)
            Me._telefono = value
        End Set
    End Property


    Public Property Email() As String
        Get
            Return Me._email
        End Get
        Set(value As String)
            Me._email = value
        End Set
    End Property
    Public Property DAOInvestigador() As DAOInvestigador
        Get
            Return Me._daoInvestigador
        End Get
        Set(value As DAOInvestigador)
            Me._daoInvestigador = value
        End Set
    End Property

    Public Sub readInvestigador()
        Me._daoInvestigador.read(Me)
    End Sub

    Public Sub readAll()
        Me._daoInvestigador.readAll()
    End Sub

    Public Sub insertInvestigador()
        Me._daoInvestigador.insert(Me)
    End Sub

    Public Sub updateInvestigador()
        Me._daoInvestigador.update(Me)
    End Sub

    Public Sub deleteInvestigador()
        Me._daoInvestigador.delete(Me)
    End Sub
End Class
