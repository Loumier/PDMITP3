﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XF.tp3.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConexao();

    }
}
