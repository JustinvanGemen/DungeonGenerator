using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Generator : MonoBehaviour {
    public Rooms[] Chambers;
    public Rooms StartingChamber;

    public int GenerationLoops = 7;

    private void Start()
    {
        var pendingExits = new List<Connectors>(StartingChamber.GetExits());

        for (var i = 0; i < GenerationLoops; i++)
        {
            var newExits = new List<Connectors>();

            foreach (var pendingExit in pendingExits)
            {
                var newTag = GetRandom(pendingExit.Tags);
                var newRoomPrefab = GetRandomWithTag(Chambers, newTag);
                var newRoom = Instantiate(newRoomPrefab);
                var newRoomExits = newRoom.GetExits();
                var exitToMatch = newRoomExits.FirstOrDefault(x => x.IsDefault) ?? GetRandom(newRoomExits);
                MatchExits(pendingExit, exitToMatch);
                newExits.AddRange(newRoomExits.Where(e => e != exitToMatch));
            }

            pendingExits = newExits;
        }
    }
    
    private static void MatchExits(Component oldConnector, Component newConnector)
    {
        var newRoom = newConnector.transform.parent;
        var forwardToMatch = -oldConnector.transform.forward;
        var correctRotation = Azimuth(forwardToMatch) - Azimuth(newConnector.transform.forward);
        newRoom.RotateAround(newConnector.transform.position, Vector3.up, correctRotation);
        var correctTranslation = oldConnector.transform.position - newConnector.transform.position;
        newRoom.transform.position += correctTranslation;
    }
    
    private static TItem GetRandom<TItem>(TItem[] array)
    {    
        return array[Random.Range(0, array.Length)];
    }


    private static Rooms GetRandomWithTag(IEnumerable<Rooms> rooms, string tagToMatch)
    {
        var matchingRooms = rooms.Where(m => m.Tags.Contains(tagToMatch)).ToArray();
        return GetRandom(matchingRooms);
    }
    
    private static float Azimuth(Vector3 vector)
    {
        return Vector3.Angle(Vector3.forward, vector) * Mathf.Sign(vector.x);
    }
}
