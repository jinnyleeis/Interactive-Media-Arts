using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class Reader_ControlClip : PlayableAsset, ITimelineClipAsset
{
    public Reader_ControlBehaviour template = new Reader_ControlBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<Reader_ControlBehaviour>.Create (graph, template);
        return playable;
    }
}
