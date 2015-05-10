using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace webPruebasAmigos.ClasesGenerales
{
    [Serializable()]
    public class CUsuario
    {
        public enum ETipoPerfil
        {
            Normales = 0,
            Administradores = 9
        }
        
        //Región de atributos privadas
        #region ATRIBUTOS PRIVADOS
        private int             _idPersona = 0;
        private string          _nombre = String.Empty;
        private string          _apellidos = String.Empty;
        private string          _cuenta = String.Empty;            //Es tambien su email de comunicacion
        private string          _contrasena = String.Empty;
        private string          _email = String.Empty;
        private string          _movil = String.Empty;
        private string          _foto = String.Empty;
        private ETipoPerfil     _perfil = ETipoPerfil.Normales;

        private int             _idtipoVia = 0;
        private string          _tipoVia = String.Empty;
        private string          _direccion = String.Empty;
        private string          _numero = String.Empty;
        private string          _escalera = String.Empty;
        private string          _piso = String.Empty;
        private string          _bloque = String.Empty;
        private string          _puerta = String.Empty;
        private string          _codigoPostal = String.Empty;
        private string          _pueblo = String.Empty;
        private string          _localidad = String.Empty;
        private string          _provincia = String.Empty;
        private string          _observacion = String.Empty;
        private string          _tipoPerfil = String.Empty;
        private bool            _accesoAplicacion = false;
        private string          _titulacion = String.Empty;
        private CFechaAnsi      _fechaNacimiento = new CFechaAnsi();
        #endregion

    #region PROPIEDADES PÚBLICAS
    //ID Persona
    public  int idpersona
    {
        get
        {
            return _idPersona;
        }
        set
        {
            _idPersona = value;
        }
    } 
    //Nombre
    public string nombre
    {
        get
        {
            return _nombre;
        }
        set
        {
            _nombre = value
        }
    } 
    //Apellidos
    public string apellidos
    {
        get
        {
            return _apellidos;
        }
        set
        {
            _apellidos = value
        }
    }
    //Cuenta
    public string cuenta
    {
        get
        {
            return _cuenta;
        }
        set
        {
            _cuenta = value
        }
    }
    //Contraseña
    public string contrasena
    {
        get
        {
            return _contrasena;
        }
        set
        {
            _contrasena = value
        }
    }
    //E-mail
    public string email
    {
        get
        {
            return _email;
        }
        set
        {
            _email = value
        }
    }
    //Movil
    public string movil
    {
        get
        {
            return _movil;
        }
        set
        {
            _movil = value
        }
    }
    //Foto
    public string foto
    {
        get
        {
            return _foto;
        }
        set
        {
            _foto = value
        }
    }
    //Perfil
    public ETipoPerfil Perfil
    {
        get
        {
            return _perfil;
        }
        set
        {
            _perfil = value
        }
    }


        private int             _idtipoVia = 0;
        private string          _tipoVia = String.Empty;
        private string          _direccion = String.Empty;
        private string          _numero = String.Empty;
        private string          _escalera = String.Empty;
        private string          _piso = String.Empty;
        private string          _bloque = String.Empty;
        private string          _puerta = String.Empty;
        private string          _codigoPostal = String.Empty;
        private string          _pueblo = String.Empty;
        private string          _localidad = String.Empty;
        private string          _provincia = String.Empty;
        private string          _observacion = String.Empty;
        private string          _tipoPerfil = String.Empty;
        private bool            _accesoAplicacion = false;
        private string          _titulacion = String.Empty;
        private CFechaAnsi      _fechaNacimiento = new CFechaAnsi();






    public  idtipoVia() As Integer
        Get
            return _idtipoVia
        } Get
        Set(ByVal value As Integer)
            _idtipoVia = value
        } Set
    } 
    public  tipoVia() As String
        Get
            return System.Enum.GetName(GetType(ETipoVia), _idtipoVia)
        } Get
        Set(ByVal value As String)
            _tipoVia = value
        } Set
    } 
    public  direccion() As String
        Get
            return _direccion
        } Get
        Set(ByVal value As String)
            _direccion = value
        } Set
    } 
    public  numero() As String
        Get
            return _numero
        } Get
        Set(ByVal value As String)
            _numero = value
        } Set
    } 
    public  escalera() As String
        Get
            return _escalera
        } Get
        Set(ByVal value As String)
            _escalera = value
        } Set
    } 
    public  piso() As String
        Get
            return _piso
        } Get
        Set(ByVal value As String)
            _piso = value
        } Set
    } 
    public  bloque() As String
        Get
            return _bloque
        } Get
        Set(ByVal value As String)
            _bloque = value
        } Set
    } 
    public  puerta() As String
        Get
            return _puerta
        } Get
        Set(ByVal value As String)
            _puerta = value
        } Set
    } 
    public  codigoPostal() As String
        Get
            return _codigoPostal
        } Get
        Set(ByVal value As String)
            _codigoPostal = value
        } Set
    } 
    public  pueblo() As String
        Get
            return _pueblo
        } Get
        Set(ByVal value As String)
            _pueblo = value
        } Set
    } 
    public  localidad() As String
        Get
            return _localidad
        } Get
        Set(ByVal value As String)
            _localidad = value
        } Set
    } 
    public  provincia() As String
        Get
            return _provincia
        } Get
        Set(ByVal value As String)
            _provincia = value
        } Set
    } 
    public  fechaIngresoClub() As LIB_FechaAnsi_2010.CFechaAnsi
        Get
            return _fechaIngresoClub
        } Get
        Set(ByVal value As LIB_FechaAnsi_2010.CFechaAnsi)
            _fechaIngresoClub = value
        } Set
    } 
    public  observacion() As String
        Get
            return _observacion
        } Get
        Set(ByVal value As String)
            _observacion = value
        } Set
    } 

    public  tipoPerfil() As String
        Get
            return _tipoPerfil
        } Get
        Set(ByVal value As String)
            _tipoPerfil = value
        } Set
    } 

    public  accesoAplicacion() As Boolean
        Get
            return _accesoAplicacion
        } Get
        Set(ByVal value As Boolean)
            _accesoAplicacion = value
        } Set
    } 

    public ReadOnly  acccesoAplicacionSQL() As Integer
        Get
            If _accesoAplicacion Then
                return 1
            Else
                return 0
            } If
        } Get
    } 
    public  titulacion() As String
        Get
            return _titulacion
        } Get
        Set(ByVal value As String)
            _titulacion = value
        } Set
    } 
    public  fechaNacimiento() As LIB_FechaAnsi_2010.CFechaAnsi
        Get
            return _fechaNacimiento
        } Get
        Set(ByVal value As LIB_FechaAnsi_2010.CFechaAnsi)
            _fechaNacimiento = value
        } Set
    } 

    public ReadOnly  nombreCompleto() As String
        Get
            return (Me.nombre & " " & Me.apellidos).Trim
        } Get
    } 

    public ReadOnly  perteneceADepartamentoCodigoInterno(ByVal codigoInterno As String) As Boolean
        Get
            Dim resultado As Boolean = False

            For Each departamento As CDepartamento In Me.colDepartamentosPersona
                If departamento.codigoInterno = codigoInterno Then
                    resultado = True
                } If
            Next

            return resultado

        } Get
    } 

#} region








    }
}