using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HssvClass.model
{
    public interface HsSv<T>
    {
        //them, sua, xoa, show thong tin
        void Them(List<T> list);
        void Sua(List<T> list);
        void Xoa(List<T> list);
        void Show(List<T> list);

    }
}