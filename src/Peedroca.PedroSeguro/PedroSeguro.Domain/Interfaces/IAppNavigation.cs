using PedroSeguro.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedroSeguro.Domain.Interfaces
{
    /// <summary>
    /// Interface de navegação na aplicação
    /// </summary>
    public interface IAppNavigation
    {
        /// <summary>
        /// Chave da página atual
        /// </summary>
        EPage CurrentPageKey { get; }

        /// <summary>
        /// Abrir página
        /// </summary>
        /// <param name="ePage">Chave da página</param>
        void OpenPage(EPage ePage);

        /// <summary>
        /// Obter página
        /// </summary>
        /// <param name="ePage">Chave da página</param>
        /// <returns>Página</returns>
        object GetPage(EPage ePage);
    }
}
