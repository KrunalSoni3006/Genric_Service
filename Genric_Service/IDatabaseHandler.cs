namespace Genric_Service
{
    using System.Collections.Generic;
    using System;
    interface IDatabaseHandler
    {
        List<T> GetData<T>();
        bool InsertData(dynamic DataModel, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "");
        bool UpdateData(dynamic DataModel, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "");
        bool DeleteData(int Id, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "");
    }
}
