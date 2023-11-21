﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI.Datos
{
    public class HelperDAO
    {
        private SqlConnection conexion;
        private string stringConexion = @"Data Source=DESKTOP-VTP20P7\MSSQLSERVER01;Initial Catalog=CINE_GRUPO21;Integrated Security=True";
        private static HelperDAO instancia;

        private HelperDAO()
        {
            conexion = new SqlConnection(stringConexion);
        }

        public static HelperDAO ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        private void Conectar()
        {
            conexion.Open();
        }

        private void Desconectar()
        {
            conexion.Close();
        }

        public int ObtenerEscalar(string nombreSP, List<Parametro> lParams, string nomParam)
        {
            int aux = 0;

            Conectar();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            foreach (Parametro p in lParams)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            SqlParameter param = new SqlParameter(nomParam, SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();

            aux = (int)param.Value;
            return aux;
        }

        internal DataTable Consultar(string nombreSP)
        {
            Conectar();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        internal DataTable Consultar(string nombreSP, List<Parametro> lParams)
        {
            Conectar();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            foreach (Parametro p in lParams)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
}
}
