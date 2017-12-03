﻿using ProjetoFinal.Dados;
using ProjetoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Business
{
    public class LocacaoBusiness
    {

        public DataTable GetItens()
        {
            LocacaoDados objID = new LocacaoDados();

            return objID.Consultar();
        }

        public void SetItem(Locacao item)
        {
            LocacaoDados objID = new LocacaoDados();

            objID.InserirLocacao(item);
        }

        public DataTable getFilmesLocacao(String codigo)
        {
            LocacaoDados objID = new LocacaoDados();
            try
            {
                return objID.ConsultarFilmes(codigo);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void excluirFilmeLocacao(String codigoLocacao, String codigoItem, String codigoFilme)
        {
            LocacaoDados objID = new LocacaoDados();
            try
            {
                objID.excluirFilmeLocacao(codigoLocacao, codigoItem, codigoFilme);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void cadastrarLocacao(Locacao locacao)
        {
            LocacaoDados objID = new LocacaoDados();
            try
            {
                objID.InserirLocacao(locacao);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
