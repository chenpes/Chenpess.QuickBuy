using System.Collections.Generic;
using System.Linq;
using Chenpess.QuickBuy.Dominio.Contratos;
using Chenpess.QuickBuy.Repositorio.Contexto;

namespace Chenpess.QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly QuickBuyContexto _quickBuyContexto;

        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            _quickBuyContexto = quickBuyContexto;
        }
        public void adicionar(TEntity entity)
        {
            _quickBuyContexto.Set<TEntity>().Add(entity);
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
            return _quickBuyContexto.Set<TEntity>().ToList();
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
