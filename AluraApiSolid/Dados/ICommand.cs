using AluraApiSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Dados
{
    public interface ICommand<T>
    {
        void Incluir(T obj);
        void Alterar(T obj, int id);
        void Excluir(T obj);
    }
}
