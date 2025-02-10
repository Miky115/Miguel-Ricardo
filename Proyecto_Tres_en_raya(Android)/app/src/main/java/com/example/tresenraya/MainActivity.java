package com.example.tresenraya;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    Button button, button2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        button = findViewById((R.id.button));
        button2 = findViewById((R.id.button2));
        button.setOnClickListener(this);
        button2.setOnClickListener(this);
    }

    public void onClick(View view) {
        Intent intent;
        intent = new Intent(MainActivity.this, unJugador.class);
        startActivity(intent);
    }
}