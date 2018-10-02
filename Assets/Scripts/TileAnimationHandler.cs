using UnityEngine;
using System.Collections;

public class TileAnimationHandler : MonoBehaviour {
  public float scaleSpeed;
  public float growSize;
  private Transform _transform;
  private Vector3 growVector;

  public void AnimateEntry() {
    StartCoroutine("AnimationEntry");
  }

  public void AnimateUpgrade() {
    StartCoroutine("AnimationUpgrade");
  }

  private IEnumerator AnimationEntry() {
    while (_transform == null) {
      yield return null;
    }

    _transform.localScale = new Vector3(0.2f, 0.2f, 1f);
    while (_transform.localScale.x < 0.2f) {
      _transform.localScale = Vector3.MoveTowards(_transform.localScale, Vector3.one, scaleSpeed * Time.deltaTime);
      yield return null;
    }
  }

  private IEnumerator AnimationUpgrade() {
    while (_transform == null) {
      yield return null;
    }

    while (_transform.localScale.x < 1f + growSize) {
      _transform.localScale = Vector3.MoveTowards(_transform.localScale, Vector3.one + growVector, scaleSpeed * Time.deltaTime);
      yield return null;
    }

    while (_transform.localScale.x > 1f) {
      _transform.localScale = Vector3.MoveTowards(_transform.localScale, Vector3.one, scaleSpeed * Time.deltaTime);
      yield return null;
    }
  }

  void Start() {
    _transform = transform;
    growVector = new Vector3(growSize, growSize, 0f);
  }
}
