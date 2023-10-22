using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsPlanetStats.ApiDataAccsess;
public interface IApiDataReader
{
    Task<string> Read(string baseAddress, string requestUri);
}