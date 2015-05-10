using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webPruebasAmigos.ClasesGenerales
{
    public class CGlobal
    {
        public enum EidiomaNavegador
        {
            Spanish = 0
        English = 1


    //Roles
     public enum EnumRoles
     {
        Administradores = 1
        Gestores = 2
    
    'FutbolData
    public enum ETipoBoolean
    {
        [True] = 1
        [False] = 0
        Ninguno = -1
    

    Public Enum ETipoFase As Integer
    {
        Regular = 0
        Final = 1
        Semifinal = 2
        Cuartos = 3
        Octavos = 4
        Dieciseisavos = 5
        Preliminar = 10
    End Enum

    Public Enum ETipoElementoBaseProfesional As Integer
    {
        Todos = -1
        Profesional = 1
        Base = 0
    End Enum

    Public Enum EEstadoPartido As Byte
    {
        SinComenzar = 0
        Finalizado = 7
        Suspendido = 8  'Partido comenzado
        Aplazado = 9    'Partido NO comenzado
    End Enum

    Public Enum ETipoDeGol As Byte
    {
        Jugada_colectiva = 1
        Jugada_individual = 2
        Penalty = 3
        Rechace = 4
        Propia_puerta = 5
        Otro = 6
        Falta_directa = 7
        Remate_falta = 8
        Corner_directo = 9
        Remate_corner = 10
        Saque_banda = 11
        Saque_porteria = 12
        Rechace_poste = 13
    End Enum

    Public Enum EEntrenamientoPrevistoRealizado As Byte
    {
        Ninguno = 0
        Previsto = 1
        Realizado = 2
    End Enum

    Public Enum ETipoTarjeta As Byte
    {
        Amarilla = 1
        Roja = 2
    End Enum

    Enum enumEstadoCliente As Byte
    {
        ninguna = 0
        demo = 1
        activo = 2
        desactivado = 3
    End Enum

    Public Shared Function StringUICultureToEidiomaNavegador(ByVal String_Idioma_Navegador As String) As EidiomaNavegador
    {
        Dim resultado As EidiomaNavegador
        If String_Idioma_Navegador.Contains("English") Then
            resultado = EidiomaNavegador.English
        Else
            resultado = EidiomaNavegador.Spanish
        End If
        Return resultado
    End Function

    Public Shared Function CalculaEdadSegunFechaNacimiento(ByVal Fecha_Nacimiento As Date) As Byte
    {
        'Dim Fecha_Actual As Date
        Dim anios As Integer

        If Fecha_Nacimiento <= #1/1/1900# Then Return 0

        anios = DateDiff("yyyy", Fecha_Nacimiento, Now)

        If DatePart("m", Now) < DatePart("m", Fecha_Nacimiento) Then
            anios = DateDiff("yyyy", Fecha_Nacimiento, Now) - 1
        ElseIf DatePart("m", Now) = DatePart("m", Fecha_Nacimiento) Then
            If DatePart("d", Now) < DatePart("d", Fecha_Nacimiento) Then
                anios = DateDiff("yyyy", Fecha_Nacimiento, Now) - 1
            End If
        End If

        If anios > 254 Or anios < 0 Then
            Return 0
        Else
            Return anios
        End If

    End Function

    Public Shared Function FunTransformaHexADec(ByVal valor As String) As Integer
    {
        int valor1, valor2, aux;

        /*Const A As Byte = 10
        Const B As Byte = 11
        'Const C As Byte = 12
        'Const D As Byte = 13
        'Const E As Byte = 14
        'Const F As Byte = 15*/

        If IsNumeric(Left(valor, 1)) Then
            valor1 = CInt(Left(valor, 1)) * 16
        Else
            Select Case UCase(Left(valor, 1))
                Case "A" : aux = 10
                Case "B" : aux = 11
                Case "C" : aux = 12
                Case "D" : aux = 13
                Case "E" : aux = 14
                Case "F" : aux = 15
            End Select
            valor1 = aux * 16
        End If

        If IsNumeric(Right(valor, 1)) Then
            valor2 = CInt(Right(valor, 1))
        Else
            Select Case UCase(Right(valor, 1))
                Case "A" : aux = 10
                Case "B" : aux = 11
                Case "C" : aux = 12
                Case "D" : aux = 13
                Case "E" : aux = 14
                Case "F" : aux = 15
            End Select
            valor2 = aux
        End If

        Return valor1 + valor2

    End Function

    Public Shared Function FunTransformaDecAHex(ByVal valor As Integer) As String
    {
        Dim digito1 As String = String.Empty, digito2 As String = String.Empty
        Dim aux As Integer

        aux = Fix(valor / 16)

        If aux < 10 Then
            digito1 = aux
        Else
            Select Case aux
                Case 10 : digito1 = "A"
                Case 11 : digito1 = "B"
                Case 12 : digito1 = "C"
                Case 13 : digito1 = "D"
                Case 14 : digito1 = "E"
                Case 15 : digito1 = "F"
            End Select
        End If

        aux = valor - (aux * 16)
        If aux < 10 Then
            digito2 = aux
        Else
            Select Case aux
                Case 10 : digito2 = "A"
                Case 11 : digito2 = "B"
                Case 12 : digito2 = "C"
                Case 13 : digito2 = "D"
                Case 14 : digito2 = "E"
                Case 15 : digito2 = "F"
            End Select
        End If

        Return digito1 & digito2
    End Function

    Public Shared Function devuelveDiaSemana(ByVal fecha As Date) As String
    {
        Select Case Weekday(fecha)
            Case 1
                Return "Domingo"
            Case 2
                Return "Lunes"
            Case 3
                Return "Martes"
            Case 4
                Return "Miércoles"
            Case 5
                Return "Jueves"
            Case 6
                Return "Viernes"
            Case 7
                Return "Sábado"
        End Select
    End Function

    Public Shared Function FunTransColorADec(ByVal valorHex As String) As String
    {
        Dim valores(2) As String

        If valorHex <> "" Then
            valores(0) = Mid(valorHex, 2, 2)
            valores(1) = Mid(valorHex, 4, 2)
            valores(2) = Mid(valorHex, 6, 2)

            Return CGlobal.FunTransformaHexADec(valores(0)) & "," _
                & CGlobal.FunTransformaHexADec(valores(1)) & "," _
                & CGlobal.FunTransformaHexADec(valores(2))
        Else
            Return ""
        End If

    End Function

    Public Shared Function FunTransColorAHex(ByVal valorDecimal As String) As String
    {
        Dim valores() As String

        valores = valorDecimal.Split(",")
        If IsNumeric(valores(0)) AndAlso IsNumeric(valores(1)) AndAlso IsNumeric(valores(2)) Then
            Return "#" _
                    & CGlobal.FunTransformaDecAHex(CInt(valores(0))) _
                    & CGlobal.FunTransformaDecAHex(CInt(valores(1))) _
                    & CGlobal.FunTransformaDecAHex(CInt(valores(2)))
        Else
            Return ""
        End If

    End Function

    public static String transformaFechaFormatoAnsi(DateTime fecha)
    {    
        String fechaFinal;
        String dia, mes, anio, hora, minuto,segundo;

        dia = fecha.Day.ToString().PadLeft(2,'0');
        mes = fecha.Month.ToString().PadLeft(2,'0');
        anio = fecha.Year.ToString().PadLeft(4,'0');
        hora = fecha.Hour.ToString().PadLeft(2,'0');
        minuto = fecha.Minute.ToString().PadLeft(2,'0');
        segundo = fecha.Second.ToString().PadLeft(2,'0');

        fechaFinal = anio + mes + dia + " " + hora + ":" + minuto + ":" + segundo; //YYYYMMDD hh:mm:ss

        return fechaFinal;
    }


    public enum tipoClaveAleatoria
    {
        numerica = 0,
        alfabetica = 1,
        alfanumerica = 2
    }    

    public static string generaClaveAleatoria(int NumDigitos, tipoClaveAleatoria Tipo, string Comienzo) 
    {    
        string aux, tipoAux;
        string claveAleatoria = String.Empty;
        //Tipo es si es una clave numérica(0),alfabética(1) o alfanumérica(2)
        //comienzo es por si se quieren dar una serie de letras al principio de la clave que no sean aleatorias

        if Comienzo.Trim <> "" Then
            claveAleatoria = Comienzo.Trim
            If claveAleatoria.Length >= NumDigitos Then
                claveAleatoria = claveAleatoria.Substring(0, NumDigitos)
                Return claveAleatoria
            End If
        End If

        Randomize()

        Do While claveAleatoria.Length < NumDigitos
            aux = ""
            Select Case Tipo
                Case tipoClaveAleatoria.numerica                'Clave numérica
                    aux = Int(10 * Rnd())
                Case tipoClaveAleatoria.alfabetica              'Clave alfabética
                    aux = FunGeneraLetraAleatoria()
                Case tipoClaveAleatoria.alfanumerica            'Clave alfanumérica
                    Randomize()
                    tipoAux = Int(2 * Rnd())
                    Select Case tipoAux
                        Case 0
                            aux = Int(10 * Rnd())
                        Case Else
                            aux = FunGeneraLetraAleatoria()
                    End Select
                Case Else                                       'Clave alfanumérica
                    Randomize()
                    tipoAux = Int(2 * Rnd())
                    Select Case tipoAux
                        Case 0
                            aux = Int(10 * Rnd())
                        Case Else
                            aux = GeneraLetraAleatoria()
                    End Select
            End Select
            claveAleatoria = claveAleatoria.Trim & aux.Trim
        Loop

        Return claveAleatoria

    }

    public static String GeneraLetraAleatoria()
    {
        String letra;
        String[] Lista = new String[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        Random rand = new Random(DateTime.Now);
        letra = Lista(Int((26 * rnd.Next())));
        return letra;
    }

    public enum ETipoEtiqueta
    {
        Jugador = 0,
        Equipo = 1
    }

    public enum ETipoPosicion
    {
        Todos = 0,
        Simple = 1,
        Detallada = 2
    }

    public enum EDiestroZurdo
    {
        Diestro = 1,
        Zurdo = 2
    }

#region ATRIBUTOS PRIVADOS
        private int     _id = 0;
        private String  _descripcion = String.Empty;
#endregion

#region PROPIEDADES PUBLICAS
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public String descripcion
        {    
            get
            {
                return _descripcion;
            }               
            set
            {
                _descripcion = value;
            }    
        
        }    
#endregion

#region CONSTRUCTORES
        Sub New()

        End Sub
        Sub New(ByVal p_id As Integer, ByVal p_descripcion As String)
            _id = p_id
            _descripcion = p_descripcion
        End Sub
#endregion
    
    }
}