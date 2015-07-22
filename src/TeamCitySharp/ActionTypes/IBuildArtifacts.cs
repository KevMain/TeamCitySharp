using System;

namespace TeamCitySharp.ActionTypes
{
    public interface IBuildArtifacts
    {
        void DownloadArtifactsByBuildId(string buildId, string destination);

        ArtifactWrapper ByBuildConfigId(string buildConfigId);
    }
}