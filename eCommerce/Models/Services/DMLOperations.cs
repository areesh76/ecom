using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Commerce.DataServices;
using eCommerce.CommonCode;

namespace eCommerce.Models.Services
{
    public class DMLOperations
    {
        private static DMLOperations instance;

        public static DMLOperations Instance{
            get { 
                if(instance == null) {
                    instance = new DMLOperations(); 
                }
                return (instance);
            }
        }
        private DMLOperations()
        {

        }
        public void NewUser(user users) {
            using (var context = DataContextHelper.GetCPDataContext()) {
                context.Insert(users);
                
            }
        }

        public user getUser(int userID){
            using (var context = DataContextHelper.GetCPDataContext()) {
                var sql = PetaPoco.Sql.Builder.Select("*").From("users").Where("ID = @0", userID);
                return context.Fetch<user>(sql).FirstOrDefault();
            }
        }

        public List<user> getUsers(){
            using (var context = DataContextHelper.GetCPDataContext()) {
                var sql = PetaPoco.Sql.Builder.Select("*").From("users");
                return context.Fetch<user>(sql).ToList();
            }
        }
    }
}