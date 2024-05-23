using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Interfaces.AutoMapper
{
    public interface IMapper
    {
        //Bir kaynağı (source) belirtilen türdeki (TDestination) bir hedefe (map) dönüştüren bir metod.
        //Ignore parametresi isteğe bağlı olarak belirli alanları dikkate almadan mapleme yapmayı sağlar
        TDestination Map<TDestination, TSource>(TSource source, string? ignore = null);

        //Bir kaynak listesini (source) belirtilen türdeki (TDestination) bir hedef listesine(map) dönüştüren bir metod.
        //Ignore parametresi isteğe bağlı olarak belirli alanları döikkate almadan mapleme yapmayı sağlar.

        IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string ignore = null);

        //Genel bir kaynağı (source) belirtilen türdei (TDestination) bir hedefe (map) dönüştüren bir metod.
        TDestination Map<TDestination>(object source, string? ignore = null);
        //Genel bir kaynak listesini (source) belirtilen türdeki (TDestination) bir hedef listesine (map) dönüştüren bir metod.
        IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null);
    }
}
