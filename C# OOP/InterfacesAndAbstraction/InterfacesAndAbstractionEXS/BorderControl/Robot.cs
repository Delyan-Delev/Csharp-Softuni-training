﻿namespace BorderControl
{
    public class Robot : IId
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get;}
        public string Id { get; }

        public string BirthDate =>"no birthDate";

        public string Birthdate => "no birthdate";
    }
}
