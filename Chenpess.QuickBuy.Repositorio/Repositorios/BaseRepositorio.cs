using System.Collections.Generic;
using Chenpess.QuickBuy.Dominio.Contratos;

namespace Chenpess.QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        public BaseRepositorio()
        {

        }
        public void adicionar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity obterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> obterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
