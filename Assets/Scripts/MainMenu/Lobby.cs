using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class Lobby : NetworkLobbyManager {

    void Start()
    {
    }
	// Use this for initialization
	public void Click () {
        MMStart();
        MMListMatches();
	}
	
    void MMStart()
    {
        Debug.Log("@ MMStart");

        this.StartMatchMaker();
    }

    void MMListMatches()
    {
        Debug.Log("@ MMListMatches");

        this.matchMaker.ListMatches(0, 20, "", true, 0, 0, OnMatchList);
    }
    public override void OnMatchList(bool success, string extendedInfo, List<MatchInfoSnapshot> matchList)
    {
        Debug.Log("@ OnMatchList");
        base.OnMatchList(success, extendedInfo, matchList);

        if (success)
        {
            if (matchList.Count > 0)
            {
                Debug.Log("Successfully listed matches. 1st match: " + matchList[0]);
                MMJoinMatch(matchList[0]);
            }
            else
            {
                MMCreateMatch();
            }
        }
        else
        {
            Debug.Log("List failed: " + extendedInfo);
        }
    }
    void MMJoinMatch(MatchInfoSnapshot match)
    {
        Debug.Log("@ MMJoinMatch");

        this.matchMaker.JoinMatch(match.networkId, "", "", "", 0, 0, OnMatchJoined);
    }

    public override void OnMatchJoined(bool success, string extendedInfo, MatchInfo matchInfo)
    {
        Debug.Log("@ MMOnMatchJoined");
        base.OnMatchJoined(success, extendedInfo, matchInfo);

        if (success)
        {
            Debug.Log("Successfully joined match: " + matchInfo.networkId);
        }
        else
        {
            Debug.Log("Failed to join match: " + extendedInfo);
        }
    }
    void MMCreateMatch()
    {
        Debug.Log("@ MMCreateMatch");

        this.matchMaker.CreateMatch("MM", 15, true, "", "", "", 0, 0, OnMatchCreate);
    }

    public override void OnMatchCreate(bool success, string extendedInfo, MatchInfo matchInfo)
    {
        Debug.Log("@ MMOnMatchCreate");
        base.OnMatchCreate(success, extendedInfo, matchInfo);

        if(success)
        {
            Debug.Log("Successfully create match: " + matchInfo.networkId);
        }
        else
        {
            Debug.Log("Failed to create match: " + extendedInfo);
        }
    }
}
