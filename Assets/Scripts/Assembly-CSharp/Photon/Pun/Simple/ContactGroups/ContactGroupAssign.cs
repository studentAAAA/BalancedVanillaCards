using UnityEngine;

namespace Photon.Pun.Simple.ContactGroups
{
	public class ContactGroupAssign : MonoBehaviour, IContactGroupsAssign, IContactGroupMask
	{
		public ContactGroupMaskSelector contactGroups;

		[Tooltip("Will add a ContactGroupAssign to any children that have colliders and no ContactGroupAssign of their own. ")]
		[SerializeField]
		protected bool applyToChildren = true;

		public bool ApplyToChildren
		{
			get
			{
				return applyToChildren;
			}
		}

		public int Mask
		{
			get
			{
				return contactGroups.Mask;
			}
		}
	}
}
