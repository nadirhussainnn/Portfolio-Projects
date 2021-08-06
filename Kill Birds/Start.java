import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


class Start implements Runnable{
	
	static JFrame f=new JFrame("Kill the Birds");
	static JProgressBar bar=new JProgressBar();
	static int filled=0;	
	
	public static void main(String args[]){
		
		setInterface();		

	}
	public static void setInterface(){
	
		f.setSize(800,600);
		f.setLocationRelativeTo(null);
		f.setDefaultCloseOperation(f.EXIT_ON_CLOSE);
		f.setLayout(null);
		f.setResizable(false);
		f.getContentPane().setBackground(Color.BLACK);
		JLabel loading=new JLabel("<html><font size=6 color=white>Loading Game...");
		Font font=new Font("Courier",Font.BOLD, 18);
		
		bar.setStringPainted(true);
		loading.setBounds(310,200,200,50);
		bar.setBounds(100,300,600,20);
		bar.setBorderPainted(false);
		bar.setBackground(Color.BLACK);
		bar.setForeground(Color.PINK);
		bar.setFont(font);
		
		Thread thread=new Thread(new Start());
		thread.start();
			
		
		f.add(loading);
		f.add(bar);
		f.setVisible(true);
		
	}
	public void run(){
		
		while(filled<=100){
			try{
				bar.setValue(filled);
				Thread.sleep(10);
				if(filled>=30 && filled<=45){
					Thread.sleep(100);
				}
				if(filled>=75 && filled<=85){
					Thread.sleep(150);
				}
				if(filled==90){
				Thread.sleep(1000);
				}
				filled++;
			}catch(InterruptedException ie){}
		}	
		
		Game.setInterface();
		f.setVisible(false);
	}	
}