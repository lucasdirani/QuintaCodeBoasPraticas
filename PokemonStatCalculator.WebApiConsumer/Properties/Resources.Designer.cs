﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokemonStatCalculator.WebApiConsumer.Properties {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PokemonStatCalculator.WebApiConsumer.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a {
        ///    &quot;userName&quot;: &quot;lruizd&quot;,
        ///    &quot;email&quot;: &quot;lucas.dirani@gmail.com&quot;,
        ///    &quot;password&quot;: &quot;5CodeIndr@&quot;
        ///}.
        /// </summary>
        internal static string LoginJSON {
            get {
                return ResourceManager.GetString("LoginJSON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a {
        ///    &quot;pokemonToBeTrained&quot;: {
        ///        &quot;name&quot;: &quot;Glastrier&quot;
        ///    },
        ///    &quot;nature&quot;: {
        ///        &quot;name&quot;: &quot;Adamant&quot;
        ///    },
        ///    &quot;level&quot;: {
        ///        &quot;value&quot;: 100
        ///    },
        ///    &quot;effortValues&quot;: {
        ///        &quot;hp&quot;: 4,
        ///        &quot;attack&quot;: 252,
        ///        &quot;defense&quot;: 252,
        ///        &quot;specialAttack&quot;: 0,
        ///        &quot;specialDefense&quot;: 0,
        ///        &quot;speed&quot;: 0
        ///    },
        ///    &quot;individualValues&quot;: {
        ///        &quot;hp&quot;: 31,
        ///        &quot;attack&quot;: 31,
        ///        &quot;defense&quot;: 31,
        ///        &quot;specialAttack&quot;: 31,
        ///        &quot;specialDefense&quot;: 31,
        ///        &quot;speed [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string PokemonTrainingJSON {
            get {
                return ResourceManager.GetString("PokemonTrainingJSON", resourceCulture);
            }
        }
    }
}