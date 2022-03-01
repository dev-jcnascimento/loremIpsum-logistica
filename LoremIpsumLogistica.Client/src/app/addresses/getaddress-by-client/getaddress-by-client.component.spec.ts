import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetaddressByClientComponent } from './getaddress-by-client.component';

describe('GetaddressByClientComponent', () => {
  let component: GetaddressByClientComponent;
  let fixture: ComponentFixture<GetaddressByClientComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetaddressByClientComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetaddressByClientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
