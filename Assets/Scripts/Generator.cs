using System.Linq;
using UnityEngine;
using System.Collections.Generic;

public class Generator : MonoBehaviour {
    
    /*Psuedo Code
        -Array of rooms
        -A variable to show what kind of room to use as default starting room
        -A variable to declare the amount of iterations the generator should do before it stops generating.
        
        -Start function 
            -Instantiate the starting room
            -A list of exists that haven't been used yet
            
            -For loop to go through the iteration variable declared above
                -A list of the new exists added this iteration
                -For each pending exit you create a bunch of variables
                    -One for a random tag which it gets from function declared below the start function
                    -One to get a random room prefab and giving it the tag from the variable above
                    -var newRoom instantiate randomPrefabWithTag
                    -get the exits from this room
                    -add those exits to the list of exits that havent been used
                    
            -A match exit function 
                -add a new room to an exit with transform properties of the parent
                -Get a vector the room has to match by subtracting the transform of the exit the room is being attached too.
                -Get the correct rotation using azimuth angles
                -Rotate the room into its correct rotation
                -Subtract the new transform position from the old one to get a corrective translation
                -add the corrective translation to the current position
                
            -A static TItem called RandomRange which returns a random range between 0 and the length of the room array.
            -A static float that contains a calculation for Azimuth's.

    */
}
