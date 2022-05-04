using System;
using System.Collections;

namespace phoneList
{
    public class Rehber
    {
        private String name;
        private string surname;
        private string telNumber;

        public Rehber(){

        }

        public Rehber(String name,String surname, String telNumber){
            this.name=name;
            this.surname=surname;
            this.telNumber=telNumber;
        }

        public String getName(){
            return this.name;
        }
        public String getSurname(){
            return this.surname;
        }
        public String getTelNumber(){
            return this.telNumber;
        }
        public void setName(String name){
            this.name=name;
        }
        public void setSurname(String surname){
            this.surname=surname;
        }
        public void setTelNumber(String telNumber){
            this.telNumber=telNumber;
        }



    }
}