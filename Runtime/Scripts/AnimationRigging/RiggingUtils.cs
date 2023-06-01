// Copyright (c) Meta Platforms, Inc. and affiliates.

using UnityEngine;

namespace Oculus.Movement.AnimationRigging
{
    public class RiggingUtilities
    {
        /// <summary>
        /// Find bone transform from skeleton assuming the bone exists.
        /// </summary>
        /// <param name="skeleton">Skeleton to query.</param>
        /// <param name="boneId">ID of bone to find.</param>
        /// <returns></returns>
        public static Transform FindBoneTransformFromSkeleton(OVRSkeleton skeleton,
            OVRSkeleton.BoneId boneId)
        {
            var bones = skeleton.Bones;
            for (int boneIndex = 0; boneIndex < bones.Count; boneIndex++)
            {
                if (bones[boneIndex].Id == boneId)
                {
                    return bones[boneIndex].Transform;
                }
            }
            return null;
        }

        /// <summary>
        /// Find bone transform from animator.
        /// </summary>
        /// <param name="animator">Animator to query.</param>
        /// <param name="boneId">Bone ID to query.</param>
        /// <returns></returns>
        public static Transform FindBoneTransformAnimator(Animator animator,
            OVRSkeleton.BoneId boneId)
        {
            if (!CustomMappings.BoneIdToHumanBodyBone.ContainsKey(boneId))
            {
                return null;
            }
            return animator.GetBoneTransform(CustomMappings.BoneIdToHumanBodyBone[boneId]);
        }
    }
}
