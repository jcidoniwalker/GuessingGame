using System;

namespace GuessingGame
{
    class User
    {
        #region Local Variables
        private string Username; // Username holds the players chosen username
        private int Points; // Points holds the amount of points a player has
        #endregion

        // User() creates a new instance of a user, storing their chosen username and starting them off with 5000 points
        public User(string _username)
        {
            this.Username = _username;
            Points = 5000;
        }
        // AddPoints() adds the value passed through to the user
        public void AddPoints(int x)
        {
            Points += x;
        }
        // SubtractPoints() deducts the value passed through from the user 
        public void SubtractPoints(int x)
        {
            Points -= x;
        }
        // GetUsername() will return the Username of the user
        public string GetUsername()
        {
            return this.Username;
        }
        // GetPoints() will return the amount of Points the user has
        public int GetPoints()
        {
            return this.Points;
        }
    }
}
