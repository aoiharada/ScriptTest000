using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
        private int hp = 100;          
        private int power = 25; 

        
        public void Attack()
        {
                Debug.Log( this.power + "�̃_���[�W��^����" );
        }

        
        public  void Defence(int damage)
        {
                Debug.Log( damage+"�̃_���[�W���󂯂�" );
                
                this.hp -= damage;
        }

}

public class Test : MonoBehaviour
{

        void Start ()
        {
            int[] array = {10,20,30,40,50};
            for(int i=0;i<5;i++){
                Debug.Log(array[i]);
            for( int i = 4; i >= 0 ; i-- ) {
               Debug.Log( array[i] );
            }
        }
               
                Boss lastboss = new Boss ();

                
                lastboss.Attack();
                
                lastboss.Defence(3);
        }

        
        void Update ()
        {

        }
}