using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileAnimationHandler : MonoBehaviour {
  public float scaleSpeed;
  public float growSize;
  private Transform _transform;
  private Vector3 growVector;
  private AudioSource sound01;

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

    _transform.localScale = new Vector3(1f, 1f, 1f);
    while (_transform.localScale.x < 1f) {
      _transform.localScale = Vector3.MoveTowards(_transform.localScale, Vector3.one, scaleSpeed * Time.deltaTime);

            yield return null;
    }
  }

  private IEnumerator AnimationUpgrade() {
    while (_transform == null) {
      yield return null;
    }
        sound01.PlayOneShot(sound01.clip);

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
    sound01 = GetComponent<AudioSource>();
    }
}
