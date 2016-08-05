using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fielgm2_WebNewsAggregator
{
    public class DatabaseWorker
    {
        //database context
        UsersDbDataContext usersDb;
        public DatabaseWorker()
        {
            //initialises the db context
            usersDb = new UsersDbDataContext();            
        }

        //adds a new user to the database
        public void addUserToDb(string userName, string password)
        {
            tblUser user = new tblUser();
            user.userName = userName;
            user.userPassword = password;
            
            usersDb.tblUsers.InsertOnSubmit(user);
            usersDb.SubmitChanges();
        }

        //adds a new like for a user to the database
        public void addALike(string likeToAdd, int userID)
        {
            Debug.WriteLine(userID);
            tblLike like = new tblLike();
            like.likes = likeToAdd;
            like.userID = userID;
            usersDb.tblLikes.InsertOnSubmit(like);

            usersDb.SubmitChanges();
        }

        //adds a new dislike for a user to the database
        public void addADislike(string dislikeToAdd, int userID)
        {
            tblDislike dislike = new tblDislike();
            dislike.dislike = dislikeToAdd;
            dislike.userID = userID;
            usersDb.tblDislikes.InsertOnSubmit(dislike);

            usersDb.SubmitChanges();
        }

        //checks for a user to login to
        public int checkForUserToLogin(string username, string password)
        {
            int notFound = -1;
            var users = from user in usersDb.tblUsers
                        select user;

            foreach(var user in users)
            {
                if((user.userName == username)&&(user.userPassword == password))
                {
                    return user.userID;
                }
            }

            return notFound;
        }

        //gets the likes of a user from the database
        public List<string> getLikes(int userID)
        {
            List<string> likesList = new List<string>();

            var userLikes = from likes in usersDb.tblLikes
                            join users in usersDb.tblUsers on likes.userID equals users.userID
                            where likes.userID == userID
                            select likes;
            
            foreach(var like in userLikes)
            {
                likesList.Add(like.likes);
            }

            return likesList;
        }

        //gets the dislikes of a user from the database
        public List<string> getDislikes(int userID)
        {
            List<string> dislikesList = new List<string>();

            var userDislikes = from dislikes in usersDb.tblDislikes
                               join users in usersDb.tblUsers on dislikes.userID equals users.userID
                               where dislikes.userID == userID
                               select dislikes;

            foreach (var dislike in userDislikes)
            {
                dislikesList.Add(dislike.dislike);
            }

            return dislikesList;
        }
    }
}
