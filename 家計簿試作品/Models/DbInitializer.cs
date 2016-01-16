using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace 家計簿試作品.Models
{
    public class DbInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            //仮データの作成
            var members = new List<Member>
            {
                new Member
                {
                    Name = "小島"
                },
                new Member
                {
                    Name = "まじこ"
                }
            };

            //DBへの登録
            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();

        }
    }
}