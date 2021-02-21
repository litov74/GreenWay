﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using GreenWay.Models;
using Xamarin.Forms;

namespace GreenWay.Data
{
    public class TokenDatabaseController
    {
        static object locker = new object();
        SQLiteConnection database;
        public TokenDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Token>();

        }
        public Token GetToken()
        {
            lock (locker)
            {
                if (database.Table<Token>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Token>().First();
                }
            }
        }
        public int SaveToken(Token Token)
        {
            lock (locker)
            {
                if (Token.Id != 0)
                {
                    database.Update(Token);
                    return Token.Id;
                }
                else
                {
                    return database.Insert(Token);
                }
            }
        }
        public int DeleteToken(int Id)
        {
            lock (locker)
            {
                return database.Delete<Token>(Id);
            }
        }
    }
}
