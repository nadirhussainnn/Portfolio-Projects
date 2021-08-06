import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.File;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
import java.util.concurrent.*;

class Game implements Runnable{
	
	static int countScore=0, countMissed=0, countLevel=1, minutes=0, seconds=0, countBullets=1000;
	
	static JFrame f=new JFrame("Kill the Birds");
	static JButton gun1=new JButton();
	static JButton gun2=new JButton();
		
	static JButton tree1=new JButton();
	static JButton tree2=new JButton();
	
	static JLabel score=new JLabel("<html><font size=4 color=Green>Score");
	static JLabel missed=new JLabel("<html><font size=4 color=red>Missed");
	static JLabel time=new JLabel("<html><font size=4 color=red>Time Remaining");
	static JLabel level=new JLabel("<html><font size=4 color=green>Level");
	static JLabel bullets=new JLabel("Bullets: "+countBullets);
	static JLabel mission=new JLabel("<html><font size=5 color=yellow>Mission: Kill 9 birds with 12 bullets in 30 seconds ");
			
	static JTextField showScore=new JTextField("0");
	static JTextField showMissed=new JTextField("0");
	static JTextField showTime=new JTextField("0");
	static JTextField showLevel=new JTextField("01");
	
	static AudioInputStream ais;
	static Clip clip;

	public static void main(String args[]){
		setInterface();		
		
	}
	public static void setInterface(){
	
		f.setSize(800,655);
		f.setLocationRelativeTo(null);
		f.setDefaultCloseOperation(f.EXIT_ON_CLOSE);
		f.setLayout(null);
		f.setResizable(false);
		f.getContentPane().setBackground(Color.BLACK);
		
		JMenu options=new JMenu("Options");
		JMenu levels=new JMenu("Levels");
		JMenu help=new JMenu("Help");
		
		JMenuItem newGame=new JMenuItem("New Game");
		JMenuItem open=new JMenuItem("Open Game");
		JMenuItem save=new JMenuItem("Save Game");
		JMenuItem exit=new JMenuItem("Exit Game");
		
		JMenuItem easy=new JMenuItem("Easy");
		JMenuItem difficult=new JMenuItem("Difficult");
		JMenuItem hard=new JMenuItem("Hard");
		
		JMenuItem helpItem=new JMenuItem("Help");
		JMenuItem about=new JMenuItem("About Developer");
		
		options.add(newGame);
		options.add(open);
		options.add(save);
		options.add(exit);
		
		levels.add(easy);
		levels.add(difficult);
		levels.add(hard);
		
		help.add(helpItem);
		help.add(about);
		
		JMenuBar menuBar=new JMenuBar();
		menuBar.add(options);	
		menuBar.add(levels);
		menuBar.add(help);
		
		f.setJMenuBar(menuBar);	
		
	
		ImageIcon img1=new ImageIcon("TREE_A.jpg");
		ImageIcon img2=new ImageIcon("TREE_B.jpg");
		
		tree1.setIcon(img1);
		tree1.setBounds(0,100,img1.getIconWidth(),img1.getIconHeight());	
		tree1.setContentAreaFilled(false);
		tree1.setBorderPainted(false);
		
		tree2.setIcon(img2);
		tree2.setBounds(700,100,img2.getIconWidth(),img2.getIconHeight());	
		tree2.setContentAreaFilled(false);
		tree2.setBorderPainted(false);
	
		score.setBounds(50,380,100,20);
		showScore.setBounds(50,410,100,30);
		missed.setBounds(50,460,100,20);
		showMissed.setBounds(50,490,100,30);
		
		time.setBounds(620,380,150,20);
		showTime.setBounds(620,410,100,30);
		level.setBounds(620,460,100,20);
		showLevel.setBounds(620,490,100,30);
		Font font=new Font("Courier",Font.BOLD,16);
		
		showScore.setFont(font);
		showMissed.setFont(font);
		showTime.setFont(font);
		showLevel.setFont(font);
		bullets.setFont(font);
		bullets.setForeground(Color.CYAN);
		
		showScore.setHorizontalAlignment(JTextField.CENTER);
		showMissed.setHorizontalAlignment(JTextField.CENTER);
		showLevel.setHorizontalAlignment(JTextField.CENTER);
		showTime.setHorizontalAlignment(JTextField.CENTER);
		
		ImageIcon ic1=new ImageIcon("GUN1.jpg");
		ImageIcon ic2=new ImageIcon("GUN2.jpg");
		gun1.setIcon(ic1);
		gun2.setIcon(ic2);
		
		gun1.setBounds(285,380,ic1.getIconWidth(),ic1.getIconHeight());
		bullets.setBounds(325,400,110,50);
		gun2.setBounds(390,380,ic2.getIconWidth(),ic2.getIconHeight());
		
		gun1.setContentAreaFilled(false);
		gun1.setBorderPainted(false);
		gun2.setContentAreaFilled(false);
		gun2.setBorderPainted(false);
		
		gun1.addActionListener(new NowFaceTheMusic());
		gun2.addActionListener(new NowFaceTheMusic());
		
		showScore.setEditable(false);	
		showMissed.setEditable(false);
		
		showTime.setEditable(false);	
		showLevel.setEditable(false);
		
		Thread timeProcessor=new Thread(new Timer());		
		timeProcessor.start();	
											//fly the birds
		Thread flyBird1=new Thread(new BirdFlier1());
		flyBird1.start();
		
		Thread flyBird2=new Thread(new BirdFlier2());
		flyBird2.start();
		
		Thread backgroundMusic=new Thread(new Game());				//Play the music
		backgroundMusic.start();
		
		Thread missionDetectore=new Thread(new MoveMission());
		missionDetectore.start();
	
		f.add(score);
		f.add(showScore);
		f.add(missed);
		f.add(showMissed);
		f.add(time);
		f.add(showTime);
		f.add(level);
		f.add(showLevel);
		f.add(bullets);
		f.add(gun1);
		f.add(gun2);
		f.add(mission);	
		f.setVisible(true);
		
	}
	public void run(){
		
		try{
			ais=AudioSystem.getAudioInputStream(new File("NoOne.WAV").getAbsoluteFile());
			clip=AudioSystem.getClip();
			clip.open(ais);
			clip.loop(Clip.LOOP_CONTINUOUSLY);
		}catch(Exception ex){}					
	}
}
class NowFaceTheMusic extends Game implements ActionListener, Runnable{

	static JButton bullet2=new JButton();
	static Boolean didCollideWithBird2=false, didCollideWithBird1=false, didKilledTheBird;
	
	static int x_axis_of_bird1=0, x_axis_of_bird2=0;
	
	public void actionPerformed(ActionEvent ae){
		
		JButton b=(JButton)ae.getSource();
		if(b==gun1 && countBullets>0 && Integer.parseInt(showTime.getText())>0){
			countBullets--;
			bullets.setText("Bullets: "+countBullets);
			Thread shooter1=new Thread(new Shooter());
			Shooter.bullet.setIcon(Shooter.icon);
			Shooter.bullet.setContentAreaFilled(false);
			Shooter.bullet.setBorderPainted(false);
			f.add(Shooter.bullet);			
			shooter1.start();
			Thread sound1=new Thread(new SoundProducer());
			sound1.start();	
		}	
		else if(b==gun2 && countBullets>0 && Integer.parseInt(showTime.getText())>0){		
			countBullets--;
			bullets.setText("Bullets: "+countBullets);
			Thread shooter2=new Thread(new NowFaceTheMusic());
			bullet2.setIcon(Shooter.icon);
			bullet2.setContentAreaFilled(false);
			bullet2.setBorderPainted(false);
			f.add(bullet2);	
			shooter2.start();
			Thread sound1=new Thread(new SoundProducer());
			sound1.start();
			}	
		if(countBullets==0){
			JOptionPane.showMessageDialog(null,"<html><font color=red>No more bullets!\n<html><font 					color=green>");
		}
		if(Integer.parseInt(showTime.getText())==0){
			JOptionPane.showMessageDialog(null,"<html><font color=red>Time Over\n<html><font 					color=green>");
			
		}				
	}
	
	public void run(){
		try{	
			bullet2.setVisible(true);
			for(int i=380;i>=-40;i--){
				bullet2.setBounds(453,i,Shooter.icon.getIconWidth(),Shooter.icon.getIconHeight());
				Thread.sleep(1);
				x_axis_of_bird2=BirdFlier1.findPointOfCollision();	
				x_axis_of_bird1=BirdFlier2.findPointOfCollision();
				
				if(x_axis_of_bird2>=370 && x_axis_of_bird2<=450 && i<=140 && i>=50){
					didCollideWithBird2=true;
					BirdFlier1.bird2.setVisible(false);
					Thread th=new Thread(new WhenKilledTheBird());
					th.start();
					bullet2.setVisible(false);
					break;		
				}
				else if(x_axis_of_bird1>=370 && x_axis_of_bird1<=450 && i<=140 && i>=50){
					didCollideWithBird1=true;
					bullet2.setVisible(false);
					BirdFlier2.bird1.setVisible(false);
					Thread th=new Thread(new WhenKilledTheBird());
					th.start();
					break;		
				}
			}
			
			if(didCollideWithBird1!=true && didCollideWithBird2!=true){
				countMissed++;
				showMissed.setText(""+countMissed);
			}
			if(didCollideWithBird2==true){
				countScore++;
				showScore.setText(""+countScore);
				didCollideWithBird2=false;
				BirdFlier1.bird2.setVisible(true);
				BirdFlier1.x_axis=770;		
				BirdFlier1.y_axis=125;
				
			}
			if(didCollideWithBird1==true){
				countScore++;
				showScore.setText(""+countScore);
				didCollideWithBird1=false;
				BirdFlier2.bird1.setVisible(true);
				BirdFlier2.x_axis=-40;		
				BirdFlier2.y_axis=125;
			}
			
		}catch(Exception ex){}

	}
}
//For firing bullet from Gun1
class Shooter extends NowFaceTheMusic implements Runnable{

	static ImageIcon icon=new ImageIcon("BULLET.jpg");
	static JButton bullet=new JButton();
	static int x_axis_of_bird1=0, x_axis_of_bird2=0;
	static Boolean didCollideWithBird1=false, didCollideWithBird2=false;	
	public void run(){
		try{	
			bullet.setVisible(true);
			for(int i=380;i>=-40;i--){
				bullet.setBounds(287,i,icon.getIconWidth(),icon.getIconHeight());
				Thread.sleep(1);
				x_axis_of_bird1=BirdFlier2.findPointOfCollision();
				x_axis_of_bird2=BirdFlier1.findPointOfCollision();	
				if(x_axis_of_bird1>=215 && x_axis_of_bird1<=280 && i<=140 && i>=50){
					didCollideWithBird1=true;
					bullet.setVisible(false);
					BirdFlier2.bird1.setVisible(false);
					Thread th=new Thread(new WhenKilledTheBird());
					th.start();
					
					break;		
				}
				if(x_axis_of_bird2>=215 && x_axis_of_bird2<=280 && i<=140 && i>=50){
					didCollideWithBird2=true;
					bullet.setVisible(false);
					BirdFlier1.bird2.setVisible(false);
					Thread th=new Thread(new WhenKilledTheBird());
					th.start();
					
					break;		
				}
			}
			if(didCollideWithBird1!=true && didCollideWithBird2!=true){
				countMissed++;
				showMissed.setText(""+countMissed);
			}
			if(didCollideWithBird1==true){
				countScore++;
				showScore.setText(""+countScore);
				didCollideWithBird1=false;
				BirdFlier2.bird1.setVisible(true);
				BirdFlier2.x_axis=-40;		
				BirdFlier2.y_axis=125;
			}
			if(didCollideWithBird2==true){
				countScore++;
				showScore.setText(""+countScore);
				didCollideWithBird2=false;
				BirdFlier1.bird2.setVisible(true);
				BirdFlier1.x_axis=770;		
				BirdFlier1.y_axis=125;
			}
		
		}catch(Exception ex){}		
	}
}
class BirdFlier1 extends Game implements Runnable{
	
	static int turn=0;
	static JButton bird2=new JButton();
	static ImageIcon ic=new ImageIcon("BIRD_A.jpg");
	static ImageIcon ic2=new ImageIcon("BIRD_C.jpg");
	
	static int x_axis=776, y_axis=125;
	public void run(){
		bird2.setIcon(ic);
		bird2.setBorderPainted(false);
		bird2.setContentAreaFilled(false);
		f.add(tree2);
		f.add(bird2);
		while(true){
	
			bird2.setBounds(x_axis,y_axis,ic.getIconWidth(), ic.getIconHeight());
			if(x_axis<=-65){
				x_axis=776;
				y_axis=125;
			}
			if(x_axis%8==0)
				y_axis--;
				x_axis--;
	
			if(turn%2==0 && x_axis<=-65){
				bird2.setIcon(ic2);
			}
			else if(turn%2==1 && x_axis<=-65)
			bird2.setIcon(ic);	
	
				
			try{
				Thread.sleep(3);
			}
			catch(InterruptedException ie){
		
			}
			turn++;
		}	
		
	}
	public static int findPointOfCollision(){
	return x_axis;
	}
}
class BirdFlier2 extends Game implements Runnable{
	
	static int turn=0;
	static JButton bird1=new JButton();
	static ImageIcon ic=new ImageIcon("BIRD_B.jpg");
	static ImageIcon ic2=new ImageIcon("BIRD_D.jpg");
	static int x_axis=-10, y_axis=150;
	public void run(){
		bird1.setIcon(ic);	
		bird1.setBorderPainted(false);
		bird1.setContentAreaFilled(false);
		f.add(tree1);
		f.add(bird1);
		while(true){
			bird1.setBounds(x_axis,y_axis,ic.getIconWidth(), ic.getIconHeight());			
			
			if(turn%2==0 && x_axis==800){
				bird1.setIcon(ic2);
				turn++;	
			}
			else if(turn%2==1 && x_axis==800){
				bird1.setIcon(ic);
				turn++;		
			}
			if(x_axis==800){
				x_axis=-10;
				y_axis=125;
			}
			if(x_axis%6==0)
				y_axis--;
				x_axis++;
			
			try{
				Thread.sleep(3);
			}
			catch(InterruptedException ie){
		
			}
			turn++;	
		}	
	}
		public static int findPointOfCollision(){
		
		return x_axis;	
	} 
}

class SoundProducer extends NowFaceTheMusic implements Runnable{

	public void run(){
	
		try{
			ais=AudioSystem.getAudioInputStream(new File("M1.WAV").getAbsoluteFile());
			clip=AudioSystem.getClip();
			clip.open(ais);
			clip.start();
			}
		catch(Exception ex){}		
	}	
}

class Timer extends Game implements Runnable{

	public void run(){
		try{
			for(int i=500;i>=0;i--){
			showTime.setText(""+i);
			Thread.sleep(1000);
			if(i<=10){
			showTime.setBackground(Color.RED);
			showTime.setForeground(Color.WHITE);
			}
			}
		}catch(InterruptedException ie){}
	}
}
class MoveMission extends Game implements Runnable{
	 
	public void run(){
	
		for(int i=800;i>=-450;i--){
			mission.setBounds(i,540,450,50);	
			try{Thread.sleep(30);}catch(Exception ex){}
			if(i<=-450){
			i=800;}
		}
	}
}
class WhenKilledTheBird implements Runnable{
	
	static AudioInputStream ais;
	static Clip clip;
	
	public void run(){
		try{
		ais=AudioSystem.getAudioInputStream(new File("KillSound.WAV").getAbsoluteFile());	
		clip=AudioSystem.getClip();
		clip.open(ais);
		clip.start();
		}catch(Exception ex){}
	}
}