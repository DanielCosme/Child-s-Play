﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof(Tower))]
public class Laser : Projectile
{
    [SerializeField] private float secondPerTick;
    [SerializeField] private float secondItLast;

    //new void Update()
    //{
    //    base.Update();
    //    HittingTarget();
    //}
    //[SerializeField]
    //private Light _lightEffect;

    ////[SerializeField]
    ////private ParticleSystem _vfxCloud;

    //[SerializeField]
    //private ParticleSystem _vfxBeam;

    //[SerializeField]
    ////private LineRenderer _lineRendererComponent;

    ////private Tower _tower;

    private void Start()
    {
        //_tower = this.GetComponent<Tower>();
    }

    new void Update()
    {
        base.Update();
        HittingTarget();
    }

    public override void Damage(Transform enemy)
    {
        StartCoroutine(enemy.GetComponent<Enemy>().DamageOverTime(damageValue, secondPerTick, secondItLast));
    }
    //private new void Update()
    //{
    //if (_tower.GetTowerTarget == null)
    //{
    //    _lineRendererComponent.enabled = false;
    //    this.impactVFX.Stop();
    //    this._lightEffect.enabled = false;

    //    _vfxBeam.Stop();
    //    //_vfxCloud.Stop();
    //}

    //}

    //public void FireLaserBeam()
    //{
    //    //TODO: DAMAGE INPUT


    //    //GRAPHICS PART
    //    _lineRendererComponent.enabled = true;

    //    _lineRendererComponent.SetPosition(0, _tower.GetProjectileSpawnPoint.position);
    //    _lineRendererComponent.SetPosition(1, _tower.GetTowerTarget.position);

    //    this.impactVFX.Play();
    //    //this._vfxCloud.Play();
    //    this._lightEffect.enabled = true;

    //    Vector3 direction = _tower.GetProjectileSpawnPoint.position - _tower.GetTowerTarget.position;

    //    this.impactVFX.transform.position = _tower.GetTowerTarget.position + direction.normalized;

    //    this.impactVFX.transform.rotation = Quaternion.LookRotation(direction);


    //    //this._vfxCloud.transform.position = _tower.GetTowerTarget.position + direction.normalized;

    //    _vfxBeam.Play();

    //    _vfxBeam.transform.position = _tower.GetProjectileSpawnPoint.position;
    //}

}
